using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel;
using tancverseny_applikacio.Data;

public class ProductionHandler
{
    public ProductionHandler()
    {

    }

    public List<Production> ListAcceptedProductionsByUser(int userid)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        using var context = new AppDbContext(options);

        var productions = new BindingList<Production>(context.Productions.ToList());

        var productionList = context.Productions.Where(p => p.State == "Elfogadva" && p.UserId == userid).ToList();

        return productionList;
    }

    public List<Production> ListAcceptedProductionsByCompetition(int competitionid) 
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

        using var context = new AppDbContext(options);

        var acceptedProductions = context.Productions
            .Where(p => p.CompetitionId == competitionid && p.State == "Elfogadva")
            .ToList();

        return acceptedProductions;
    }

    public List<Production> ListAllProductionsForACompetition(int competitionid) 
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        using var context = new AppDbContext(options);

        var productions = new BindingList<Production>(context.Productions.ToList());

        return context.Productions.Where(p => p.CompetitionId == competitionid).ToList();
    }
	public List<Production> ListAllProductionsForUser(int userid)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        using var context = new AppDbContext(options);

        var productions = new BindingList<Production>(context.Productions.ToList());

        return context.Productions.Where(p => p.UserId == userid).ToList();
    }
}
