using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.EntityModel;
using Report.Interface;

namespace BugManager.Models
{
    public class FilterModelBase : IFilter
    {
        public FilterModelBase(HSLTEntities entities)
        {
            DbEntities = entities;
        }
        public HSLTEntities DbEntities { get; set; }
        public long? UserId { get; set; }
    }
}