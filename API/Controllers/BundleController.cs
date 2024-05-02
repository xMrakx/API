using API.DTO.Bundle;
using API.DTO.Category;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route( "api/bundle" )]
    [ApiController]
    public class BundleController : ControllerBase
    {
        [HttpGet( "list" )]
        public IActionResult GetBundleList( [FromQuery] string accessToken )
        {
            if (true)
            {
                return Ok( new GetBundleListResponseDto()
                {
                    Success = true,
                    Data = new List<CategoryBundleDto>()
                    {
                        new CategoryBundleDto() 
                        {
                            BundleId = 1,
                            Name = "Робототехнические наборы (РТН)",
                            Count = 30
                        },
                        new CategoryBundleDto()
                        {
                            BundleId  = 2,
                            Name = "Робототехнические наборы (РТН)",
                            Count = 30
                        },
                        new CategoryBundleDto()
                        {
                            BundleId  = 3,
                            Name = "Робототехнические наборы (РТН)",
                            Count = 30
                        }
                    }
                });
            }
        }

        [HttpGet( "details" )]
        public IActionResult GetBundleDetails( [FromQuery] GetBundleDetailsRequestDto request )
        {
            if (true)
            {
                return Ok( new GetBundleDetailsResponseDto()
                {
                    Success = true,
                    Data = new()
                    {
                        BundleId = 1,
                        Name = "Робототехнические наборы (РТН)",
                        Count = 30,
                        BundleItems = new List<BundleItemDto>()
                        {
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 1,
                                Name = "Плата Arduino Uno",
                                FunctionalType = 0,
                                Available = true,
                            },
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 2,
                                Name = "Датчик линии",
                                FunctionalType = 1,
                                Available = true,
                            },
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 1,
                                Name = "Датчик наклона",
                                FunctionalType = 1,
                                Available = false,
                            },
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 30,
                                Name = "Образовательный набор «Амперка»",
                                FunctionalType = 0,
                                Available = false,
                                UnavailableReason = "Участвует в сборке №6794365"
                            },
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 30,
                                Name = "Образовательный набор «Амперка»",
                                FunctionalType = 2,
                                Available = true,
                            },
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 30,
                                Name = "Образовательный набор «Амперка»",
                                FunctionalType = 1,
                                Available = true,
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

        [HttpPost( "change-functional" )]
        public IActionResult ChangeBundleFunctional( [FromBody] ChangeBundleFunctionalRequestDto request )
        {
            if (true)
            {
                return Ok(new ChangeBundleFunctionalResponseDto()
                {
                    Success = true,
                    Data = new()
                    {
                        BundleId = 1,
                        Name = "Робототехнические наборы (РТН)",
                        Count = 30,
                        BundleItems = new List<BundleItemDto>()
                        {
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 1,
                                Name = "Плата Arduino Uno",
                                FunctionalType = 2,
                                Available = true,
                            },
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 2,
                                Name = "Датчик линии",
                                FunctionalType = 2,
                                Available = true,
                            },
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 1,
                                Name = "Датчик наклона",
                                FunctionalType = 1,
                                Available = false,
                            },
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 30,
                                Name = "Образовательный набор «Амперка»",
                                FunctionalType = 0,
                                Available = false,
                                UnavailableReason = "Участвует в сборке №6794365"
                            },
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 30,
                                Name = "Образовательный набор «Амперка»",
                                FunctionalType = 2,
                                Available = true,
                            },
                            new BundleItemDto()
                            {
                                BundleItemId = 1,
                                Count = 30,
                                Name = "Образовательный набор «Амперка»",
                                FunctionalType = 1,
                                Available = true,
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
    }
}
