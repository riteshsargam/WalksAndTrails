using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WalksAndTrails.API.Migrations
{
    /// <inheritdoc />
    public partial class SeddingdataforDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("35e31381-85ad-4e1d-95d8-f37b36fd5017"), "Medium" },
                    { new Guid("64a74235-7e9d-4def-9afe-9521be4b3e89"), "Hard" },
                    { new Guid("a05b102b-840e-4b4a-a964-9c519678ac66"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("14ceba71-4b51-4777-9b17-46602cf66153"), "BTG", "Botnaical Garden", "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F246565119%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90" },
                    { new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"), "KBR", "KBR Park", "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F171771903%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90" },
                    { new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"), "GLP", "Gandipet Lake Park", "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F239559151%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90" },
                    { new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"), "INP", "Indira Park", "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F197890372%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D342x424%26scale%3D2&w=750&q=90" },
                    { new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"), "GCF", "Golconda Fort", "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F243755818%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90" },
                    { new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"), "DGC", "Durgam Cheruvu", "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F239559151%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("35e31381-85ad-4e1d-95d8-f37b36fd5017"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("64a74235-7e9d-4def-9afe-9521be4b3e89"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("a05b102b-840e-4b4a-a964-9c519678ac66"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("14ceba71-4b51-4777-9b17-46602cf66153"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"));
        }
    }
}
