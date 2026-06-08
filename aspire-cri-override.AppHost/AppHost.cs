#pragma warning disable ASPIREPIPELINES003
using Aspire.Hosting.Publishing;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddDockerComposeEnvironment("env");

builder
    .AddProject<Projects.aspire_cri_override_App>("console")
    .WithContainerBuildOptions(options =>
    {
        options.ImageFormat = ContainerImageFormat.Oci;
        options.OutputPath = ".";
        options.TargetPlatform = ContainerTargetPlatform.WindowsAmd64;
    });

builder.Build().Run();
