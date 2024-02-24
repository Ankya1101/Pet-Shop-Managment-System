using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AnimalToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_Animals_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalId = table.Column<int>(nullable: true),
                    CommentMessage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Mamal" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Reptile" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Aquatic" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "CategoryId", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { 1, 10, 1, "The eastern grey kangaroo (Macropus giganteus) is a marsupial found in eastern third of Australia, with a population of several million. It is also known as the great grey kangaroo and the forester kangaroo. Although a big eastern grey male typically masses around 66 kg (weight 145 lb.) and stands almost 2 m (6.6 ft.) tall, the scientific name, Macropus giganteus (gigantic large-foot), is misleading: the red kangaroo of the semi-arid inland is larger, weighing up to 90 kg.", "/images/Animals/kangaroo.jpg", "Eastern grey kangaroo" },
                    { 4, 11, 1, "The giant panda (Ailuropoda melanoleuca; Chinese: 大熊猫; pinyin: dàxióngmāo),[5] also known as the panda bear or simply the panda, is a bear[6] native to south central China. It is characterised by large, black patches around its eyes, over the ears, and across its round body. The name giant panda is sometimes used to distinguish it from the red panda, a neighboring musteloid. Though it belongs to the order Carnivora, the giant panda is a folivore, with bamboo shoots and leaves making up more than 99% of its diet. Giant pandas in the wild will occasionally eat other grasses, wild tubers, or even meat in the form of birds, rodents, or carrion. In captivity, they may receive honey, eggs, fish, yams, shrub leaves, oranges, or bananas along with specially prepared food.", "/images/Animals/giantpanda.jpg", "Giant Panda" },
                    { 2, 13, 2, "Lizards are a widespread group of squamate reptiles, with over 6,000 species,ranging across all continents except Antarctica, as well as most oceanic island chains. The group is paraphyletic as it excludes the snakes and Amphisbaenia; some lizards are more closely related to these two excluded groups than they are to other lizards. Lizards range in size from chameleons and geckos a few centimeters long to the 3 meter long Komodo dragon.", "/images/Animals/stellagama.jpg", "Stellagama stellio" },
                    { 5, 44, 2, "The desert tortoise (Gopherus agassizii), is a species of tortoise native to the Mojave and Sonoran Deserts of the southwestern United States and northwestern Mexico and the Sinaloan thornscrub of northwestern Mexico.[3] G. agassizii is distributed in western Arizona, southeastern California, southern Nevada, and southwestern Utah.[3] The specific name agassizii is in honor of Swiss-American zoologist Jean Louis Rodolphe Agassiz. In 2011, on the basis of DNA, geographic, and behavioral differences between desert tortoises east and west of the Colorado River, it was decided that two species of desert tortoises exist: Agassiz's desert tortoise (Gopherus agassizii) and Morafka's desert tortoise (Gopherus morafkai). G. morafkai occurs east of the Colorado River in Arizona, as well as in the states of Sonora and Sinaloa, Mexico. This species may be a composite of two species.", "/images/Animals/deserttortoise.jpg", "Desert Tortoise" },
                    { 3, 15, 3, "The king penguin (Aptenodytes patagonicus) is the second largest species of penguin, smaller, but somewhat similar in appearance to the emperor penguin. There are two subspecies: A. p. patagonicus and A. p. halli; patagonicus is found in the South Atlantic and halli in the South Indian Ocean (at the Kerguelen Islands, Crozet Island, Prince Edward Islands and Heard Island and McDonald Islands) and at Macquarie Island.", "/images/Animals/penguin.jpg", "King penguin" },
                    { 6, 7, 3, "Jellyfish and sea jellies are the informal common names given to the medusa-phase of certain gelatinous members of the subphylum Medusozoa, a major part of the phylum Cnidaria. Jellyfish are mainly free-swimming marine animals with umbrella-shaped bells and trailing tentacles, although a few are not mobile, being anchored to the seabed by stalks. The bell can pulsate to provide propulsion and highly efficient locomotion. The tentacles are armed with stinging cells and may be used to capture prey and defend against predators. Jellyfish have a complex life cycle; the medusa is normally the sexual phase, the planula larva can disperse widely and is followed by a sedentary polyp phase.", "/images/Animals/jellyfish.jpg", "Jellyfish" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AnimalId", "CommentMessage" },
                values: new object[,]
                {
                    { 1, 1, "good animal" },
                    { 2, 1, "decent animal" },
                    { 3, 1, "not bad animal" },
                    { 4, 2, "nice animal" },
                    { 5, 2, "good lizard" },
                    { 6, 3, "pinguins are okay animal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CategoryId",
                table: "Animals",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AnimalId",
                table: "Comments",
                column: "AnimalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
