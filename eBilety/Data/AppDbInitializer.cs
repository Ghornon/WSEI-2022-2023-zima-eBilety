using eBilety.Data.Enums;
using eBilety.Data.Static;
using eBilety.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace eBilety.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Data seeds

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Multikino",
                            Logo = "https://pbs.twimg.com/profile_images/1127509295/logo_multikino.jpg",
                            Description = "Sieć kin Multikino: premiery i maratony filmowe. Sprawdź aktualny repertuar i kup bilet on-line!"
                        },
                        new Cinema()
                        {
                            Name = "Cinema City",
                            Logo = "https://www.cinema-city.pl/mrest/logos/v1/10103/logo.svg",
                            Description = "DOŚWIADCZENIE KINOWE PRZEKRACZAJĄCE GRANICE WYOBRAŹNI. Ten moment kiedy przenosisz się do innej epoki lub galaktyki. Przebłysk akustycznej przezroczystości dźwięku, która powoduje przyspieszone bicie serca. Chwila w której zapominasz o otaczającym Cię świecie. Gdy zaczynasz się śmiać, a chwilę potem śmieje się cała sala."
                        },
                        new Cinema()
                        {
                            Name = "Helios",
                            Logo = "https://www.helios.pl/img/logo.helios_ua.png",
                            Description = "Kino Konesera; Kino Kobiet; Maratony filmowe; Helios dla dzieci; Kultura Dostępna; Helios na scenie; Grupy. Oferta dla firm; Helios dla szkoły; Akademia Filmowa; Kino na Temat; Kino na Temat Jr; Kino."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3D",
                            Logo = "https://cinema3d.pl/images/logo-green.svg",
                            Description = "Sieć kin Cinema 3D: premiery i maratony filmowe."
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            Avatar = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            Avatar = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            Avatar = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            Avatar = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            Avatar = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.ActorsMovies.Any())
                {
                    context.ActorsMovies.AddRange(new List<ActorMovie>()
                    {
                        new ActorMovie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new ActorMovie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new ActorMovie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new ActorMovie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new ActorMovie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new ActorMovie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new ActorMovie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new ActorMovie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new ActorMovie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin Admin",
                        UserName = "admin",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Admin@1234!");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "jan.kowalski@gmail.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Jan Kowalski",
                        UserName = "jan-kowalski",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Janek@1234!");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
