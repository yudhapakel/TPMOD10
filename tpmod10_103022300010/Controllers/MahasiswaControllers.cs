using Microsoft.AspNetCore.Mvc;

namespace tpmod10_103022300010.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaControllers : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Yudha Harwanto Putra", Nim = "103022300010" },
            new Mahasiswa { Nama = "Nicholas Putra Irawan", Nim = "103022330091" },
            new Mahasiswa { Nama = "Benaya Giuseppe Linggaputra Sinulingga", Nim = "103022330122" },
            new Mahasiswa { Nama = "Nur Ilmi Mufidah", Nim = "103022300005" },
            new Mahasiswa { Nama = "Sidqi Athallah Ar-Rasyid", Nim = "103022300108" },
            new Mahasiswa { Nama = "Rizqie Ahmad Zakaria Hende", Nim = "103023300118" }
        };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
            {
                return NotFound();
            }
            return mahasiswaList[index];
        }

        [HttpPost]
        public ActionResult<List<Mahasiswa>> Post([FromBody] Mahasiswa mhs)
        {
            mahasiswaList.Add(mhs);
            return mahasiswaList;
        }
        [HttpDelete("{index}")]
        public ActionResult<List<Mahasiswa>> Delete(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
            {
                return NotFound();
            }
            mahasiswaList.RemoveAt(index);
            return mahasiswaList;
        }
    }
}
