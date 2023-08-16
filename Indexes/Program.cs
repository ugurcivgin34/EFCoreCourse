using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

ApplicationDbContext context = new();

#region Index Nedir?
//Index, bir sütuna dayalı sorgulamaları daha verimli ve performanslı hale getirmek için kullanılan yapıdır.
#endregion
#region Index'leme Nasıl Yapılır?
//PK, FK ve AK olan kolonlar otomatik olarak indexlenir. 

#region Index Attribute'u

#endregion
#region HasIndex Metodu

#endregion
#endregion
#region Composite Index
//context.Employees.Where(e => e.Name == "" || e.Surname == "")
#endregion
#region Birden Fazla Index Tanımlama

#endregion
#region Index Uniqueness

#endregion
#region Index Sort Order - Sıralama Düzeni (EF Core 7.0)

#region AllDescending - Attribute
//Tüm indexlemelerde descending davranışının bütünsel olarak konfigürasyonunu sağlar.
#endregion
#region IsDescending - Attribute
//Indexleme sürecindeki her bir kolona göre sıralama davranışını hususi ayarlamak istiyorsak kullanılır.
#endregion
#region IsDescending Metodu

#endregion
#endregion
#region Index Name

#endregion
#region Index Filter

#region HasFilter Metodu

#endregion
#endregion
#region Included Columns

#region IncludeProperties Metodu

#endregion
#endregion



//[Index(nameof(Name))]
//[Index(nameof(Surname))]
//[Index(nameof(Name), nameof(Surname))]
//[Index(nameof(Name), AllDescending = true)]
//[Index(nameof(Name), nameof(Surname), IsDescending = new[] { true, false })]
//[Index(nameof(Name), Name = "name_index")]
class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Salary { get; set; }
}

class ApplicationDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelbuilder.entity<employee>()
        //.hasındex(x => x.name);
        //.hasındex(x => new { x.name, x.surname });
        //.hasındex(nameof(employee.name), nameof(employee.surname));
        //.hasındex(x => x.name)
        //.ısunique();

        //modelbuilder.entity<employee>()
        //    .hasındex(x => x.name)
        //    .ısdescending();

        //modelbuilder.entity<employee>()
        //    .hasındex(x => new { x.name, x.surname })
        //    .ısdescending(true, false);

        //modelbuilder.entity<employee>()
        //    .hasındex(x => x.name)
        //    .hasdatabasename("name_index");

        //modelbuilder.entity<employee>()
        //    .hasındex(x => x.name)
        //    .hasfilter("[name] ıs not null");

        modelBuilder.Entity<Employee>()
            .HasIndex(x => new { x.Name, x.Surname })
            .IncludeProperties(x => x.Salary);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB;User ID=SA;Password=1q2w3e4r+!;TrustServerCertificate=True");
    }
}