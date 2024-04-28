using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TPMOD10_1302223055;
    internal class mhs_db : DbContext
{
    public mhs_db(DbContextOptions<mhs_db> options) // default setting untuk database
        : base(options) { }
    public DbSet<Mahasiswa> mhs => Set<Mahasiswa>();
}
