using Aspire.Hosting;

IDistributedApplicationBuilder builder = DistributedApplication.CreateBuilder(args);


builder.AddProject<Projects.AppWeb_BlazorServer_FluentUI_HolisticWare>
                (
                    "app-web-holisticware"
                    // "../../AppWeb.BlazorServer.FluentUI.HolisticWare/AppWeb.BlazorServer.FluentUI.HolisticWare.csproj"
                );
builder.AddProject<Projects.AppWeb_BlazorServer_FluentUI_HolisticWare_Ph4ct3x>
                (
                    "app-web-holisticware-ph4ct3x"
                );

// builder.AddProject<Projects.AppWeb_YARP_ReverseProxy>
//                                         (
//                                             "app-web-yarp-reverse-proxy"
//                                         );


 // Add this using directive

// builder.AddYarp("ingress")
//     .WithEndpoint(hostPort: 8001, scheme: "http")
//     .Route("app1", path: "/app1", target: app1)
//     .Route("app2", path: "/app2", target: app2);


builder.Build().Run();
