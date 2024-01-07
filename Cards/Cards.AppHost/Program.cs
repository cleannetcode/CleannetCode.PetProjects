var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Cards_UI>("Cards.UI");

builder.Build().Run();
