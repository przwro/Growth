﻿using Growth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Growth.Application.Common.Interfaces;

public interface IApplicationDbContext : IDisposable
{
    DbSet<ApplicationUser> Users { get; set; }
    DbSet<Address> Addresses { get; set; }
    DbSet<Friend> Friends { get; set; }
    DbSet<House> Houses { get; set; }

}
