namespace JournalProgram
{


    public class Entry
    {
        private string _response;
        private string _prompt;
        private string _date;

        public Entry(string userResponse, string programPrompt)
        {
            _response = userResponse;
            _prompt = programPrompt;
            _date = DateTime.Now.ToString("yyyy-MM-dd");

        }
        public string DisplayString()
        {
            string escapeResponse = _response.Replace(",", " ");
            return $"{_date}, {_prompt}, {escapeResponse}";
        }

        public string SaveString()
        {
            string escapeResponse = _response.Replace(",", " ");
            return $"{_date},{_prompt},{escapeResponse}";
        }

        public string GetString()
        {
            return $"{_date},{_prompt},{_response}";
        }
    }
}
