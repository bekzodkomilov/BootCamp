using System;
using System.Collections.Generic;
using System.Linq;


namespace movies.Mappers
{

    public static class ModelEntityMappers
        {
            public static Entity.Genre ToEntity(this Models.NewGenre genre)
                => new Entity.Genre(genre.Name);

            public static Entity.Actor ToEntity(this Models.NewActor actor)
                => new Entity.Actor()
                {
                    Id = Guid.NewGuid(),
                    Fullname = actor.Fullname,
                    Birthdate = actor.Birthdate
                };

            public static Entity.Movie ToEntity(this Models.NewMovie movie, 
                IEnumerable<Entity.Actor> actors, 
                IEnumerable<Entity.Genre> genres)
                    => new Entity.Movie()
                    {
                        Id = Guid.NewGuid(),
                        Title = movie.Title,
                        Description = movie.Description,
                        ReleaseDate = movie.ReleaseDate,
                        Rating = movie.Rating,
                        Actors = actors.ToList(),
                        Genres = genres.ToList()
                    };
        }
}