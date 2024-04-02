using Microsoft.EntityFrameWorkCore;
public class CollegeManagerDb : DbContext
{
    public DbSet<CollegeProgram> CollegePrograms { get; set; }
    protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source: CollegeManager.db");
        //ConnectionStrings
    }
}