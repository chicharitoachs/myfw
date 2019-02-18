using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using Data.EntityModel;
using DKC.Data;
using DKC.Data.Helper;

namespace Data
{
    public interface IObjectModel
    {
        //ObjectAttribute Attribute { get; }
    }
    public abstract class ObjectModel : IObjectModel
    {
        #region Constructions

        protected ObjectModel()
        {
        }
        protected ObjectModel(long id)
            : this()
        {
            this.Id = id;

        }
        protected ObjectModel(object model)
            : this()
        {
            this.model = model;

        }
        protected ObjectModel(object entitiesModel, object model)
            : this(model)
        {
        }

        public enum eType
        {
        }
        protected object model;
        //public readonly ObjectAttribute Attribute;

        #endregion

        #region Propertys
        public long Id { get; set; }
        public int? TrangThai { get; set; }
        public string Guid_Id { get; set; }
        [StringLength(4000, MinimumLength = 0, ErrorMessage = "Tên phải trong khoảng từ {2} đến {1} ký tự")]
        public string Name { get; set; }
        public long? CreateBy_Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? ModifyBy_Id { get; set; }
        public DateTime? ModifyDate { get; set; }
        #endregion

        #region Operations

        //ObjectAttribute IObjectModel.Attibute => this.Attribute;

        /// <summary>
        /// Kiểm tra kiểu đối tượng có File không
        /// </summary>
        public virtual bool ObjectTypeHasFile()
        {
            return false;
        }

        /// <summary>
        /// Cop
        /// </summary>
        public virtual void CopyProperty(object fromObj, object toObj)
        {
            if (model != null)
            {
                var fromType = fromObj.GetType();
                var toType = toObj.GetType();
                foreach (PropertyInfo prop in fromType.GetProperties())
                {
                    if (prop.PropertyType.Namespace == "System")
                        toType.GetProperty(prop.Name)?.SetValue(toObj, prop.GetValue(fromObj, null), null);
                }
            }
        }

        /// <summary>
        /// Insert
        /// </summary>
        public virtual long Insert(DbContext entitiesModel, long userId)
        {
            try
            {
                this.model = this.CreateModel();
                this.CreateSysProps(userId);
                this.CopyProperty(this, this.model);
                entitiesModel.Entry(model).State = EntityState.Added;
                var errors = entitiesModel.GetValidationErrors().SelectMany(k => k.ValidationErrors).Select(k => new { k.PropertyName, k.ErrorMessage }).ToList();
                if (errors.Count > 0)
                {
                    ManagerLog.Logger.ErrorModel(errors.Select(k => $"PropertyName: {k.PropertyName} -- ErrorMessage: {k.ErrorMessage}").ToList());
                    return 0;
                }
                entitiesModel.SaveChanges();
                var propIDofModel = this.model.GetType().GetProperty("Id");
                this.Id = (long?)propIDofModel?.GetValue(this.model) ?? 0;
                return this.Id;
            }
            catch (Exception e)
            {
                ManagerLog.Logger.Error(e);
                return 0;
            }
        }

        public abstract object CreateModel();

        /// <summary>
        /// Update
        /// </summary>
        public virtual bool Update(DbContext entitiesModel, long userId, long id)
        {
            try
            {
                this.Id = id;
                this.model = this.GetModel(entitiesModel, id);
                if (model != null)
                {
                    this.UpdateSysProps(userId);
                    this.CopyProperty(this, this.model);
                    //this.Update();
                    entitiesModel.Entry(model).State = EntityState.Modified;
                    var errors = entitiesModel.GetValidationErrors().SelectMany(k => k.ValidationErrors).Select(k => new { k.PropertyName, k.ErrorMessage }).ToList();
                    if (errors.Count > 0)
                    {
                        ManagerLog.Logger.ErrorModel(errors.Select(k => $"PropertyName: {k.PropertyName} -- ErrorMessage: {k.ErrorMessage}").ToList());
                        return false;
                    }
                    entitiesModel.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                ManagerLog.Logger.Error(e);
                return false;
            }
        }

        protected virtual void CreateSysProps(long userId)
        {
            if (this.model != null && (this.model is ISystemPropertyModel || this.model is ISystemPropertyAllowNullModel))
            {
                this.Guid_Id = Guid.NewGuid().ToString();
                this.CreateBy_Id = userId;
                this.CreateDate = DateTime.Now;
                this.ModifyBy_Id = userId;
                this.ModifyDate = DateTime.Now;
            }
        }
        protected virtual void UpdateSysProps(long userId)
        {
            if (model is ISystemPropertyModel)
            {
                this.Guid_Id = ((ISystemPropertyModel)this.model).Guid_Id;
                this.CreateBy_Id = ((ISystemPropertyModel)this.model).CreateBy_Id;
                this.CreateDate = ((ISystemPropertyModel)this.model).CreateDate;
                this.ModifyBy_Id = userId;
                this.ModifyDate = DateTime.Now;
            }
            else if (model is ISystemPropertyAllowNullModel)
            {
                this.Guid_Id = ((ISystemPropertyAllowNullModel)this.model).Guid_Id;
                this.CreateBy_Id = ((ISystemPropertyAllowNullModel)this.model).CreateBy_Id;
                this.CreateDate = ((ISystemPropertyAllowNullModel)this.model).CreateDate;
                this.ModifyBy_Id = userId;
                this.ModifyDate = DateTime.Now;
            }
        }
        /// <summary>
        /// Delete
        /// </summary>
        public virtual bool Delete(DbContext entitiesModel, long userId, long id, bool destroy = false)
        {
            this.Id = id;
            this.model = this.GetModel(entitiesModel, id);
            entitiesModel.Entry(model).State = EntityState.Deleted;
            entitiesModel.SaveChanges();
            return true;
            //return this.Delete(destroy);
        }
        public virtual bool ChangeState(DbContext entitiesModel, long userId, int state)
        {
            UpdateSysProps(userId);
            entitiesModel.Entry(model).State = EntityState.Modified;
            entitiesModel.SaveChanges();
            return true;
            //return this.Delete(destroy);
        }

        /// <summary>
        /// Get object model
        /// </summary>
        public abstract object GetModel(DbContext entitiesModel);

        public virtual object GetModel(DbContext entitiesModel, long id)
        {
            this.Id = id;
            return this.GetModel(entitiesModel);
        }

        public virtual long GetIdFromModel()
        {
            return 0;
        }
        #endregion
    }
}
