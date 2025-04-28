using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MockDataController : Controller
    {
        [HttpGet("photos")]
        public IActionResult GetPhotos()
        {
            var photos = new List<object>();
            for (int i = 0; i < 99; i++)
            {
                photos.Add(new 
                { 
                    Id = i, Title = $"Photo {i}", 
                    Url = $"https://example.com/photos/{i}", 
                    Thumbnail = $"https://example.com/thumbs/{i}" 
                });
            }

            return Ok(photos);
        }

        [HttpGet("comments")]
        public IActionResult GetComments()
        {
            var comments = new List<object>();
            for (int i = 0; i < 99; i++)
            {
                comments.Add(new 
                { 
                    Id = i, Name = $"Commenter {i}", 
                    Email = $"user{i}@example.com", 
                    Body = $"This is a sample comment {i}." 
                });
            }
            return Ok(comments);
        }

        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            var users = new List<object>();
            for (int i = 0; i < 99; i++)
            {
                users.Add(new
                {
                    Id = i,
                    Name = $"User {i}",
                    Username = $"user{i}",
                    Email = $"user{i}@example.com"
                });
            }
            return Ok(users);
        }
    }
}
