using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeFeedReader
{
    public class YouTubeFeedService : IDisposable
    {
        private HttpClient _httpClient;


        public YouTubeFeedService()
        {
            this._httpClient = new HttpClient();
        }


        public async Task<YouTubeFeedDocument> LoadDocumentAsync(Uri uri)
        {
            var resp = await this._httpClient.GetAsync(uri);
            if (resp.IsSuccessStatusCode == false)
                throw new WebException("Http request is not success. status = " + (int)resp.StatusCode);

            var source = await resp.Content.ReadAsStreamAsync();
            return await YouTubeFeedDocument.LoadAsync(source);
        }


        private void _checkDisposed()
        {
            if (this._httpClient == null)
                throw new ObjectDisposedException(nameof(YouTubeFeedService));
        }


        public void Dispose()
        {
            this._httpClient?.Dispose();
            this._httpClient = null;
        }
    }
}
