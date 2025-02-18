﻿using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Natucare.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CADASTROCLIENTE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Endereço = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CADASTROCLIENTE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CADASTROPRODUTOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Linha = table.Column<string>(type: "text", nullable: true),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Produto = table.Column<string>(type: "text", nullable: true),
                    PrecoVenda = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    QuantidadeEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CADASTROPRODUTOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CLIENTES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Login = table.Column<string>(type: "text", nullable: true),
                    Senha = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CADASTROCLIENTE");

            migrationBuilder.DropTable(
                name: "CADASTROPRODUTOS");

            migrationBuilder.DropTable(
                name: "CLIENTES");
        }
    }
}
