using API.DTO.Project;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route( "api/project" )]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        [HttpGet( "list" )]
        public IActionResult GetProjectList( [FromQuery] string accessToken )
        {
            if (true)
            {
                return Ok(new GetProjectListResponseDto()
                {
                    Success = true,
                    Data = new List<ProjectDataDto>()
                    {
                        new ProjectDataDto()
                        {
                            Id = 1,
                            Name = "Робот федор"
                        },
                        new ProjectDataDto()
                        {
                            Id = 2,
                            Name = "Корабль"
                        }
                    }
                });
            }

            if (false)
            {
                return BadRequest(false);
            }
        }

        [HttpGet( "details" )]
        public IActionResult GetProjectDeatails( [FromQuery] GetProjectDetailsRequestDto request )
        {
            if (true)
            {
                return Ok(new GetProjectDetailsResponseDto()
                {
                    Success = true,
                    Data = new()
                    {
                        Id = 1,
                        Name = "Робот Федор",
                        Bundles = new List<ProjectDataBundlesDto>()
                        {
                            new ProjectDataBundlesDto()
                            {
                                Id = 1,
                                Count = 30,
                                Name = "Образовательный набор «Амперка»"
                            },
                            new ProjectDataBundlesDto()
                            {
                                Id = 2,
                                Count = 1,
                                Name = "Образовательный набор «Матрёшка Z» (плата Arduino Uno на базе процессора ATmega328p)"
                            },
                            new ProjectDataBundlesDto()
                            {
                                Id = 3,
                                Count = 1,
                                Name = "Робоконструктор Makeblock Ultimate Robot Kit (без контроллера)"
                            },
                            new ProjectDataBundlesDto()
                            {
                                Id = 85,
                                Count = 1,
                                Name = "Робоконструктор Makeblock Starter Robot Kit (без контроллера)"
                            },
                            new ProjectDataBundlesDto()
                            {
                                Id = 88,
                                Count = 1,
                                Name = "Образовательный набор «Малина Z» (одноплатный компьютер Raspberry Pi 2 Model B )"
                            },
                            new ProjectDataBundlesDto()
                            {
                                Id = 140,
                                Count = 1,
                                Name = "Робототехнический набор Lego MINDSTORMS EV3 31313"
                            },
                        }
                    }
                });
            }

            if (false)
            {
                return BadRequest(false);
            }
        }

        [HttpPost( "create" )]
        public IActionResult CreateProject( [FromQuery] CreateProjectRequestDto request )
        {
            if (true)
            {
                return Ok(new CreateProjectResponseDto()
                {
                    Success = true,
                    Data = new()
                    {
                        Id = 3,
                        Name = "Что-то новое",
                        Bundles = new()
                    }
                });
            }

            if (false)
            {
                return BadRequest(false);
            }
        }

        [HttpPost( "edit" )]
        public IActionResult EditProject( [FromQuery] EditProjectRequestDto request )
        {
            if (true)
            {
                return Ok(new CreateProjectResponseDto()
                {
                    Success= true,
                    Data = new()
                    {
                        Id = 3,
                        Name = "Смена",
                        Bundles= new()
                    }
                });
            }
        }
    }
}
