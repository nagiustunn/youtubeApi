using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using youtubeApi.Response;

namespace youtubeApi
{
    public class GetRssItems
    {
        public Response<IEnumerable<RssModel>> GetRssDataItems(string rssItem)
        {
            BindingList<RssModel> rssModels = new BindingList<RssModel>();
            try
            {
                var feed = FeedReader.Read(rssItem);

                var links = feed.Items.Select(x => x.Link);

                return Response.Response.CreateSuccess(
                            feed.Items.Select(x => new RssModel { Description = x.Description, Link = x.Link, Title = x.Title })
                );
            }
            catch (Exception ex)
            {
                return Response.Response.CreateError<IEnumerable<RssModel>>(ex.Message);
            }

        }
    }
}
