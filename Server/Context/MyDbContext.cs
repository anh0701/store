using Microsoft.EntityFrameworkCore;
using Server.Entities;

namespace Server.Context;

public class MyDbConText:DbContext{
    public MyDbConText(DbContextOptions options):base(options){}
    #region DbSet
    public DbSet<ProductEntity> products{get; set;}
    public DbSet<TypeEntity> types{get; set;}
    #endregion
}