using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gatherly.Domain.Entities;
using Gatherly.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gatherly.Persistence.Configurations;
internal class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
{
    public void Configure(EntityTypeBuilder<RolePermission> builder)
    {
        builder.HasKey(x => new { x.RoleId, x.PermissionId });

        builder.HasData(
            Create(Domain.Enums.Role.Registered, Domain.Enums.Permission.ReadMember),
            Create(Domain.Enums.Role.Registered, Domain.Enums.Permission.UpdateMember));

    }

    private static RolePermission Create(Domain.Enums.Role role, Domain.Enums.Permission permission)
    {
        return new RolePermission
        {
            RoleId = (int)role,
            PermissionId = (int)permission
        };
    }
}
