using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autoservice.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkeCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkeCars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Masters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProblemDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Statement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpareParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpareParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModelCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufactureYear = table.Column<int>(type: "int", nullable: false),
                    MarkeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelCars_MarkeCars_MarkeId",
                        column: x => x.MarkeId,
                        principalTable: "MarkeCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModificationCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HP = table.Column<int>(type: "int", nullable: false),
                    EngineType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelCarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModificationCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModificationCars_ModelCars_ModelCarId",
                        column: x => x.ModelCarId,
                        principalTable: "ModelCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    PartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarParts_ModificationCars_CarId",
                        column: x => x.CarId,
                        principalTable: "ModificationCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarParts_SpareParts_PartId",
                        column: x => x.PartId,
                        principalTable: "SpareParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerCars_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerCars_ModificationCars_CarId",
                        column: x => x.CarId,
                        principalTable: "ModificationCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCheckouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerCarId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    ProblemDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaserId = table.Column<int>(type: "int", nullable: false),
                    RequestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceStatus = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCheckouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceCheckouts_CustomerCars_CustomerCarId",
                        column: x => x.CustomerCarId,
                        principalTable: "CustomerCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceCheckouts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceCheckouts_Masters_MaserId",
                        column: x => x.MaserId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSpares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpareId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSpares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceSpares_ServiceCheckouts_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "ServiceCheckouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceSpares_SpareParts_SpareId",
                        column: x => x.SpareId,
                        principalTable: "SpareParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypeSummsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: true),
                    ServiceCheckoutId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypeSummsTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceTypeSummsTypes_ServiceCheckouts_ServiceCheckoutId",
                        column: x => x.ServiceCheckoutId,
                        principalTable: "ServiceCheckouts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceTypeSummsTypes_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarParts_CarId",
                table: "CarParts",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarParts_PartId",
                table: "CarParts",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCars_CarId",
                table: "CustomerCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCars_CustomerId",
                table: "CustomerCars",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelCars_MarkeId",
                table: "ModelCars",
                column: "MarkeId");

            migrationBuilder.CreateIndex(
                name: "IX_ModificationCars_ModelCarId",
                table: "ModificationCars",
                column: "ModelCarId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCheckouts_CustomerCarId",
                table: "ServiceCheckouts",
                column: "CustomerCarId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCheckouts_CustomerId",
                table: "ServiceCheckouts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCheckouts_MaserId",
                table: "ServiceCheckouts",
                column: "MaserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSpares_ServiceId",
                table: "ServiceSpares",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSpares_SpareId",
                table: "ServiceSpares",
                column: "SpareId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypeSummsTypes_ServiceCheckoutId",
                table: "ServiceTypeSummsTypes",
                column: "ServiceCheckoutId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypeSummsTypes_ServiceTypeId",
                table: "ServiceTypeSummsTypes",
                column: "ServiceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarParts");

            migrationBuilder.DropTable(
                name: "ServiceRequests");

            migrationBuilder.DropTable(
                name: "ServiceSpares");

            migrationBuilder.DropTable(
                name: "ServiceTypeSummsTypes");

            migrationBuilder.DropTable(
                name: "SpareParts");

            migrationBuilder.DropTable(
                name: "ServiceCheckouts");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "CustomerCars");

            migrationBuilder.DropTable(
                name: "Masters");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ModificationCars");

            migrationBuilder.DropTable(
                name: "ModelCars");

            migrationBuilder.DropTable(
                name: "MarkeCars");
        }
    }
}
