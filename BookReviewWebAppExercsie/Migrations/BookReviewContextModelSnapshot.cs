﻿// <auto-generated />
using System;
using BookReviewWebAppExercsie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookReviewWebAppExercsie.Migrations
{
    [DbContext(typeof(BookReviewContext))]
    partial class BookReviewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookReviewWebAppExercsie.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Name = "J.R.R. Tolkien"
                        },
                        new
                        {
                            AuthorId = 2,
                            Name = "J.K. Rowling"
                        },
                        new
                        {
                            AuthorId = 3,
                            Name = "Stieg Larsson"
                        },
                        new
                        {
                            AuthorId = 4,
                            Name = "Gillian Flynn"
                        },
                        new
                        {
                            AuthorId = 5,
                            Name = "Matt Haig"
                        });
                });

            modelBuilder.Entity("BookReviewWebAppExercsie.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            Date = new DateTime(2002, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Written for J.R.R. Tolkien’s own children, The Hobbit met with instant critical acclaim when it was first published in 1937. Now recognized as a timeless classic, this introduction to the hobbit Bilbo Baggins, the wizard Gandalf, Gollum, and the spectacular world of Middle-earth recounts of the adventures of a reluctant hero, a powerful and dangerous ring, and the cruel dragon Smaug the Magnificent. The text in this 372-page paperback edition is based on that first published in Great Britain by Collins Modern Classics (1998), and includes a note on the text by Douglas A. Anderson (2001).",
                            Genre = "Classics",
                            Title = "The Hobbit, or There and Back Again"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2,
                            Date = new DateTime(2003, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Full of sympathetic characters, wildly imaginative situations, and countless exciting details, the first installment in the series assembles an unforgettable magical world and sets the stage for many high-stakes adventures to come.",
                            Genre = "Fantasy",
                            Title = "Harry Potter and the Sorcerer's Stone"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 3,
                            Date = new DateTime(2008, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Harriet Vanger, a scion of one of Sweden’s wealthiest families disappeared over forty years ago. All these years later, her aged uncle continues to seek the truth. He hires Mikael Blomkvist, a crusading journalist recently trapped by a libel conviction, to investigate. He is aided by the pierced and tattooed punk prodigy Lisbeth Salander. Together they tap into a vein of unfathomable iniquity and astonishing corruption.",
                            Genre = "Thriller",
                            Title = "The Girl with the Dragon Tattoo"
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 4,
                            Date = new DateTime(2014, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "One of the most critically acclaimed suspense writers of our time, New York Times bestseller Gillian Flynn takes that statement to its darkest place in this unputdownable masterpiece about a marriage gone terribly, terribly wrong. The Chicago Tribune proclaimed that her work “draws you in and keeps you reading with the force of a pure but nasty addiction.” Gone Girl’s toxic mix of sharp-edged wit and deliciously chilling prose creates a nerve-fraying thriller that confounds you at every turn.",
                            Genre = "Mystery",
                            Title = "Gone girl"
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 5,
                            Date = new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Between life and death there is a library, and within that library, the shelves go on forever. Every book provides a chance to try another life you could have lived. To see how things would be if you had made other choices . . . Would you have done anything different, if you had the chance to undo your regrets?",
                            Genre = "Fantasy",
                            Title = "The Midnight Library"
                        });
                });

            modelBuilder.Entity("BookReviewWebAppExercsie.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.ToTable("Review");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            BookId = 1,
                            Name = "Inge",
                            TextContent = "Cool Story Bro"
                        },
                        new
                        {
                            ReviewId = 2,
                            BookId = 2,
                            Name = "Zoe",
                            TextContent = "I will never ever rate this lower than 5 stars. BEAUTIFUL."
                        },
                        new
                        {
                            ReviewId = 3,
                            BookId = 3,
                            Name = "Diane Wallace",
                            TextContent = "Loved it! an interesting,mystery filled and very thrill-seeking storyline..was well written,nice movie also... (paperback!)"
                        },
                        new
                        {
                            ReviewId = 4,
                            BookId = 4,
                            Name = "NReads",
                            TextContent = "yo Amy really did THAT"
                        },
                        new
                        {
                            ReviewId = 5,
                            BookId = 5,
                            Name = "Emily B",
                            TextContent = "This was cute and the concept was great but unfortunately it really lacked some depth for me!"
                        });
                });

            modelBuilder.Entity("BookReviewWebAppExercsie.Models.Book", b =>
                {
                    b.HasOne("BookReviewWebAppExercsie.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BookReviewWebAppExercsie.Models.Review", b =>
                {
                    b.HasOne("BookReviewWebAppExercsie.Models.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookReviewWebAppExercsie.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookReviewWebAppExercsie.Models.Book", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
