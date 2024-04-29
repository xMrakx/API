using API.DTO.Category;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route( "api/category" )]
    public class CategorySetController : ControllerBase
    {
        [HttpGet( "list" )]
        public IActionResult GetCategoryList( [FromQuery] string accessToken )
        {
            if (true)
            {
                return Ok(new GetCategoryListResponseDto()
                {
                    Success = true,
                    Data = new List<CategoryDataDto>()
                    {
                        new CategoryDataDto()
                        {
                            CategoryId = 1,
                            Name = "Робототехнические наборы (РТН)",
                            Bundles = new List<CategoryBundleDto>()
                            {
                                new CategoryBundleDto()
                                {
                                    BundleId = 1,
                                    Count = 30,
                                    Name = "Образовательный набор «Амперка»"
                                },
                                new CategoryBundleDto()
                                {
                                    BundleId = 2,
                                    Count = 1,
                                    Name = "Образовательный набор «Матрёшка Z» (плата Arduino Uno на базе процессора ATmega328p)"
                                },
                                new CategoryBundleDto()
                                {
                                    BundleId = 3,
                                    Count = 1,
                                    Name = "Робоконструктор Makeblock Ultimate Robot Kit (без контроллера)"
                                },
                                new CategoryBundleDto()
                                {
                                    BundleId = 85,
                                    Count = 1,
                                    Name = "Робоконструктор Makeblock Starter Robot Kit (без контроллера)"
                                },
                                new CategoryBundleDto()
                                {
                                    BundleId = 88,
                                    Count = 1,
                                    Name = "Образовательный набор «Малина Z» (одноплатный компьютер Raspberry Pi 2 Model B )"
                                },
                                new CategoryBundleDto()
                                {
                                    BundleId = 140,
                                    Count = 1,
                                    Name = "Робототехнический набор Lego MINDSTORMS EV3 31313"
                                }
                            }

                        },
                        new CategoryDataDto()
                        {
                            CategoryId = 2,
                            Name = "Макетные платы, платформы (МП)",
                            Bundles = new List<CategoryBundleDto>()
                            {
                                new CategoryBundleDto
                                {
                                    BundleId = 4,
                                    Count = 13,
                                    Name = "Макетная плата Breadboard Mini (AMP-X008-C)"
                                },
                                new CategoryBundleDto
                                {
                                    BundleId = 5,
                                    Count = 1,
                                    Name = "Четырёхколёсная платформа Pirate-4WD Mobile Platform DFROBOT (без контроллера)"
                                },
                                new CategoryBundleDto
                                {
                                    BundleId = 6,
                                    Count = 2,
                                    Name = "Гусеничная платформа Rover 5 (без контроллера)"
                                }
                            }
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
        public IActionResult CreateCategory( [FromQuery] CreateCategoryRequestDto request )
        {
            if (true)
            {
                return Ok( new GetCategoryListResponseDto()
                {
                    Success = true,
                    Data = new List<CategoryDataDto>()
                    {
                        new CategoryDataDto 
                        { 
                            CategoryId = 3,
                            Name = "Что-то новое",
                            Bundles = new List<CategoryBundleDto>()
                            {
                                new CategoryBundleDto 
                                {
                                    BundleId = 1,
                                    Count = 13,
                                    Name = "Макетная плата Breadboard Mini (AMP-X008-C)"
                                },
                                new CategoryBundleDto
                                {
                                    BundleId = 2,
                                    Count = 1,
                                    Name = "Четырёхколёсная платформа Pirate-4WD Mobile Platform DFROBOT (без контроллера)"
                                },
                                new CategoryBundleDto
                                {
                                    BundleId = 3,
                                    Count = 2,
                                    Name = "Гусеничная платформа Rover 5 (без контроллера)"
                                }
                            }
                        }
                    }
                });
            }

            if (false) { return BadRequest(false);}
        }

        [HttpPost( "edit" )]
        public IActionResult Editcategory( [FromBody] EditCategoryRequestDto request )
        {
            if(true) 
            {
                return Ok(new GetCategoryListResponseDto()
                {
                    Success= true,
                    Data = new List<CategoryDataDto>()
                    { 
                        new CategoryDataDto
                        { 
                            CategoryId = 1,
                            Name = "Смена названия",
                            Bundles = new List<CategoryBundleDto>()
                            {
                                new CategoryBundleDto
                                {
                                    BundleId = 1,
                                    Count = 13,
                                    Name = "Макетная плата Breadboard Mini (AMP-X008-C)"
                                }
                            }
                        }}
                });
            }

            if (false)
            { 
                return BadRequest(false);
            }
        }

        [HttpPost( "delete" )]
        public IActionResult Deletecategory( [FromBody] DeleteCategoryRequestDto request )
        {
            if (true)
            {
                return Ok(true);
            }

            if (false)
            {
                return BadRequest(false);
            }
        }
    }
}
