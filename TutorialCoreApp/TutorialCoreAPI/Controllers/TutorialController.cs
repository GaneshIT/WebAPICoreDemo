using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialCoreAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TutorialCoreAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialController : ControllerBase
    {
        private readonly TutorialDbContext _tutorialDbContext;
        public TutorialController(TutorialDbContext tutorialDbContext)
        {
            _tutorialDbContext = tutorialDbContext;
        }

        [HttpGet]
        public IEnumerable<Tutorial> GetTutorials()
        {
            return _tutorialDbContext.tutorial.ToList();//select * from tutorial
        }
        [HttpGet("GetTutorialById")]
        public Tutorial GetTutorialById(int tutorialId)
        {
            return _tutorialDbContext.tutorial.Find(tutorialId);
        }

        [HttpPost("InsertTutorial")]
        public IActionResult InsertTutorial([FromBody]Tutorial tutorial)
        {
            if (tutorial.TutorialId.ToString() != "")
            {
                //insert into tutorial values(tutorial.id,tutorial,name,tutorial.desc,tutorial.publish,tutorial.fees)
                _tutorialDbContext.tutorial.Add(tutorial);
                _tutorialDbContext.SaveChanges();
                return Ok("Saved successfully");                
            }
            else
                return BadRequest(); //404 ERROR
        }

        [HttpPut("UpdateTutorial")]
        public IActionResult UpdateTutorial([FromBody] Tutorial tutorial)
        {
            if (tutorial.TutorialId.ToString() != "")
            {
                //update tutorial set name=tutorial.name , desc=tutorial.desc , fees=tutorial.fees , publish=tutorial.publish where id=tutorial.id
                _tutorialDbContext.Entry(tutorial).State = EntityState.Modified;
                _tutorialDbContext.SaveChanges();
                return Ok("Updated successfully");
            }
            else
                return BadRequest();
        }

        //localhost:3433/Tutorial/DeleteTutorial?tutorialId=3
        [HttpDelete("DeleteTutorial")]
        public IActionResult DeleteTutorial(int tutorialId)
        {
            //select * from tutorial where tutorialId=3
            var result = _tutorialDbContext.tutorial.Find(tutorialId);
            _tutorialDbContext.tutorial.Remove(result);
            _tutorialDbContext.SaveChanges();
            return Ok("Deleted successfully");
        }
    }
}

/*
UserInfo(id,fname,lname,email,pwd)
(Register,Login(email,pwd))
Movie: id,moviename,desc,movietype,language
(insert,update,delete,getMovieinfo)
*/

