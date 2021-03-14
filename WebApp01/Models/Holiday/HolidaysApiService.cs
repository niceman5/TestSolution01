using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApp01.Models.Holiday
{
    public class HolidaysApiService : IHolidaysApiService
    {
        private readonly HttpClient client;

        //IHttpClientFactory 사용시
        public HolidaysApiService(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("PublicHolidaysApi");
        }        

        //Startup.cs에서 AddHttpClient로 주입이 없을때 사용하는 방법
        /*
        static HolidaysApiService()
        {

            client = new HttpClient()
            {
                BaseAddress = new Uri("https://date.nager.at")
            };
        }
        */
        public async Task<List<HolidayModel>> GetHolidays(string countryCode, int year)
        {
            //첫 번째 줄은 Nager.Date API 의 URL 을 빌드 하고 year 및 countryCode 매개 변수를 사용하는 것입니다
            var url = string.Format("/api/v2/PublicHolidays/{0}/{1}", year, countryCode);
            var result = new List<HolidayModel>();
            
            //다음으로 지정된 Uri에 GET 요청을 비동기 작업으로 보내는 GetAsync 메서드를 사용하여 API 호출을 수행합니다. 
            //이 메서드는 상태 코드 및 데이터를 포함하는 HTTP 응답 메시지를 나타내는 System.Net.Http.HttpResponseMessage 개체를 반환 합니
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                //다음으로, HTTP 콘텐츠를 문자열로 직렬화 하는 ReadAsStringAsync 메서드를 호출 합니다.
                var stringResponse = await response.Content.ReadAsStringAsync();
                // JsonSerializer 를 사용 하여 JSON 응답 문자열을 HolidayModel 개체 목록으로 역 직렬화 합니다.

                result = JsonSerializer.Deserialize<List<HolidayModel>>(stringResponse, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
            return result;
        }
    }
}