using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using tancverseny_applikacio.Data;

public class CompetitionHandler
{
	public CompetitionHandler()
	{

	}

    public List<Competition> ListEndedCompetitions() 
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        using var context = new AppDbContext(options);

        var competitions = new BindingList<Competition>(context.Competitions.ToList());

        return context.Competitions.Where(c => c.CompetitionEnd < DateTime.Now).ToList();
    }

    public List<Competition> ListAllCompetitions()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        using var context = new AppDbContext(options);

        var competitions = new BindingList<Competition>(context.Competitions.ToList());

        return context.Competitions.ToList();
    }
}
