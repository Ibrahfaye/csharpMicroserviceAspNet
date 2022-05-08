using microservice.controller;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<productController,productController>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    //app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));
}

app.MapControllers();

app.MapGet("/products",async(productController productCtrl) 
=> await productCtrl.GetProducts());
//
//app.MapGet("/helloworld", () => "Hello World!");

app.Run();
