﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Qup.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QupEntities : DbContext
    {
        public QupEntities()
            : base("name=QupEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<BusinessOperation> BusinessOperations { get; set; }
        public virtual DbSet<BusinessProfile> BusinessProfiles { get; set; }
        public virtual DbSet<QueueTransaction> QueueTransactions { get; set; }
        public virtual DbSet<SessionLog> SessionLogs { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserLedger> UserLedgers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersToUserGroup> UsersToUserGroups { get; set; }
        public virtual DbSet<vwGetBusinessDetail> vwGetBusinessDetails { get; set; }
    
        public virtual ObjectResult<spGetCustomersInQueueByDate_Result> spGetCustomersInQueueByDate(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, Nullable<int> businessId)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("fromDate", fromDate) :
                new ObjectParameter("fromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("toDate", toDate) :
                new ObjectParameter("toDate", typeof(System.DateTime));
    
            var businessIdParameter = businessId.HasValue ?
                new ObjectParameter("businessId", businessId) :
                new ObjectParameter("businessId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetCustomersInQueueByDate_Result>("spGetCustomersInQueueByDate", fromDateParameter, toDateParameter, businessIdParameter);
        }
    
        public virtual ObjectResult<spGetUserQueue_Result> spGetUserQueue(string sessionId, Nullable<int> businessId)
        {
            var sessionIdParameter = sessionId != null ?
                new ObjectParameter("sessionId", sessionId) :
                new ObjectParameter("sessionId", typeof(string));
    
            var businessIdParameter = businessId.HasValue ?
                new ObjectParameter("businessId", businessId) :
                new ObjectParameter("businessId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUserQueue_Result>("spGetUserQueue", sessionIdParameter, businessIdParameter);
        }
    
        public virtual ObjectResult<spUsersByUserGroup_Result> spUsersByUserGroup(string userGroup)
        {
            var userGroupParameter = userGroup != null ?
                new ObjectParameter("userGroup", userGroup) :
                new ObjectParameter("userGroup", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsersByUserGroup_Result>("spUsersByUserGroup", userGroupParameter);
        }
    }
}