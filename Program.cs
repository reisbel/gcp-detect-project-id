using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace gcp_detect_project_id
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectId = GetProjectId();
            Console.WriteLine($"Project-id: {projectId.Result}");
            Console.ReadLine();
        }

        static async Task<string> GetProjectId()
        {
            try
            {
                //Metadata GCP URL
                string baseUrl = "http://metadata.google.internal/computeMetadata/v1/project/project-id";
               
                //Create a new instance of HttpClient
                using (HttpClient client = new HttpClient())
                {
                    //Add required Google Header to request this info
                    client.DefaultRequestHeaders.Add("Metadata-Flavor","Google");
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            return await content.ReadAsStringAsync();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
           
            return string.Empty;
   }   }
}
