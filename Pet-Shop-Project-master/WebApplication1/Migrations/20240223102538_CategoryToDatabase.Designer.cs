﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240223102538_CategoryToDatabase")]
    partial class CategoryToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnimalId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 10,
                            CategoryId = 1,
                            Description = "The eastern grey kangaroo (Macropus giganteus) is a marsupial found in eastern third of Australia, with a population of several million. It is also known as the great grey kangaroo and the forester kangaroo. Although a big eastern grey male typically masses around 66 kg (weight 145 lb.) and stands almost 2 m (6.6 ft.) tall, the scientific name, Macropus giganteus (gigantic large-foot), is misleading: the red kangaroo of the semi-arid inland is larger, weighing up to 90 kg.",
                            ImgUrl = "/images/Animals/kangaroo.jpg",
                            Name = "Eastern grey kangaroo"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 13,
                            CategoryId = 2,
                            Description = "Lizards are a widespread group of squamate reptiles, with over 6,000 species,ranging across all continents except Antarctica, as well as most oceanic island chains. The group is paraphyletic as it excludes the snakes and Amphisbaenia; some lizards are more closely related to these two excluded groups than they are to other lizards. Lizards range in size from chameleons and geckos a few centimeters long to the 3 meter long Komodo dragon.",
                            ImgUrl = "/images/Animals/stellagama.jpg",
                            Name = "Stellagama stellio"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 15,
                            CategoryId = 3,
                            Description = "The king penguin (Aptenodytes patagonicus) is the second largest species of penguin, smaller, but somewhat similar in appearance to the emperor penguin. There are two subspecies: A. p. patagonicus and A. p. halli; patagonicus is found in the South Atlantic and halli in the South Indian Ocean (at the Kerguelen Islands, Crozet Island, Prince Edward Islands and Heard Island and McDonald Islands) and at Macquarie Island.",
                            ImgUrl = "/images/Animals/penguin.jpg",
                            Name = "King penguin"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 11,
                            CategoryId = 1,
                            Description = "The giant panda (Ailuropoda melanoleuca; Chinese: 大熊猫; pinyin: dàxióngmāo),[5] also known as the panda bear or simply the panda, is a bear[6] native to south central China. It is characterised by large, black patches around its eyes, over the ears, and across its round body. The name giant panda is sometimes used to distinguish it from the red panda, a neighboring musteloid. Though it belongs to the order Carnivora, the giant panda is a folivore, with bamboo shoots and leaves making up more than 99% of its diet. Giant pandas in the wild will occasionally eat other grasses, wild tubers, or even meat in the form of birds, rodents, or carrion. In captivity, they may receive honey, eggs, fish, yams, shrub leaves, oranges, or bananas along with specially prepared food.",
                            ImgUrl = "/images/Animals/giantpanda.jpg",
                            Name = "Giant Panda"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 44,
                            CategoryId = 2,
                            Description = "The desert tortoise (Gopherus agassizii), is a species of tortoise native to the Mojave and Sonoran Deserts of the southwestern United States and northwestern Mexico and the Sinaloan thornscrub of northwestern Mexico.[3] G. agassizii is distributed in western Arizona, southeastern California, southern Nevada, and southwestern Utah.[3] The specific name agassizii is in honor of Swiss-American zoologist Jean Louis Rodolphe Agassiz. In 2011, on the basis of DNA, geographic, and behavioral differences between desert tortoises east and west of the Colorado River, it was decided that two species of desert tortoises exist: Agassiz's desert tortoise (Gopherus agassizii) and Morafka's desert tortoise (Gopherus morafkai). G. morafkai occurs east of the Colorado River in Arizona, as well as in the states of Sonora and Sinaloa, Mexico. This species may be a composite of two species.",
                            ImgUrl = "/images/Animals/deserttortoise.jpg",
                            Name = "Desert Tortoise"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 7,
                            CategoryId = 3,
                            Description = "Jellyfish and sea jellies are the informal common names given to the medusa-phase of certain gelatinous members of the subphylum Medusozoa, a major part of the phylum Cnidaria. Jellyfish are mainly free-swimming marine animals with umbrella-shaped bells and trailing tentacles, although a few are not mobile, being anchored to the seabed by stalks. The bell can pulsate to provide propulsion and highly efficient locomotion. The tentacles are armed with stinging cells and may be used to capture prey and defend against predators. Jellyfish have a complex life cycle; the medusa is normally the sexual phase, the planula larva can disperse widely and is followed by a sedentary polyp phase.",
                            ImgUrl = "/images/Animals/jellyfish.jpg",
                            Name = "Jellyfish"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mamal"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Reptile"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Aquatic"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("CommentMessage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnimalId = 1,
                            CommentMessage = "good animal"
                        },
                        new
                        {
                            Id = 2,
                            AnimalId = 1,
                            CommentMessage = "decent animal"
                        },
                        new
                        {
                            Id = 3,
                            AnimalId = 1,
                            CommentMessage = "not bad animal"
                        },
                        new
                        {
                            Id = 4,
                            AnimalId = 2,
                            CommentMessage = "nice animal"
                        },
                        new
                        {
                            Id = 5,
                            AnimalId = 2,
                            CommentMessage = "good lizard"
                        },
                        new
                        {
                            Id = 6,
                            AnimalId = 3,
                            CommentMessage = "pinguins are okay animal"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Animal", b =>
                {
                    b.HasOne("WebApplication1.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Comment", b =>
                {
                    b.HasOne("WebApplication1.Models.Animal", "Animal")
                        .WithMany("Comments")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
