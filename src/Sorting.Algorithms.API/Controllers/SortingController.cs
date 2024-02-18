using Microsoft.AspNetCore.Mvc;

namespace Sorting.Algorithms.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortingController : ControllerBase
    {
        [HttpPut("bubble-sort")]
        public IActionResult BubbleSort([FromBody] int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }

            return Ok(array);
        }
    }
}
