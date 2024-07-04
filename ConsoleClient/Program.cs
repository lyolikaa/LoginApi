namespace ConsoleClient;

class Program
{
    static async Task Main(string[] args)
    {
        string baseUrl = "http://localhost:5069/";

        using var httpClient = new HttpClient();
        try
        {
            HttpResponseMessage response = await httpClient.GetAsync(baseUrl + "api/endpoint");

            // Check if the response is successful
            if (response.IsSuccessStatusCode)
            {
                // Read the response content as string
                string responseData = await response.Content.ReadAsStringAsync();

                // Display the response data
                Console.WriteLine("Response from API:");
                Console.WriteLine(responseData);
            }
            else
            {
                // Handle the case where the request was not successful
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions that occur during the request
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}