﻿using System;
using SaasOvation.Common.Domain.Model;

namespace SaasOvation.IdentityAccess.Domain.Identity.Model.Tenant {
    public class TenantProvisioned: IDomainEvent {
        public string TenantId { get; private set; }

        public TenantProvisioned(TenantId tenantId) {
            this.TenantId = tenantId.Id;

            this.EventVersion = 1;
            this.OccurredOn = DateTime.Now;
        }

        public int EventVersion { get; set; }
        public DateTime OccurredOn { get; set; } 
    }
}