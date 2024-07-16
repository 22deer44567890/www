using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vk_bot
{
    internal class list_of_posts
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Asset
        {
            public string animation_url { get; set; }
            public List<Image> images { get; set; }
            public Title title { get; set; }
            public TitleColor title_color { get; set; }
        }

        public class Attachment
        {
            public string type { get; set; }
            public Photo photo { get; set; }
        }

        public class Background
        {
            public string light { get; set; }
            public string dark { get; set; }
        }

        public class Color
        {
            public Foreground foreground { get; set; }
            public Background background { get; set; }
        }

        public class Comments
        {
            public int can_post { get; set; }
            public int can_open { get; set; }
            public int can_view { get; set; }
            public int count { get; set; }
            public bool groups_can_post { get; set; }
            public int? can_close { get; set; }
        }

        public class Donut
        {
            public bool is_donut { get; set; }
        }

        public class Foreground
        {
            public string light { get; set; }
            public string dark { get; set; }
        }

        public class Image
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Item
        {
            internal static object response;

            public string inner_type { get; set; }
            public int can_delete { get; set; }
            public int can_pin { get; set; }
            public Donut donut { get; set; }
            public Comments comments { get; set; }
            public int marked_as_ads { get; set; }
            public string hash { get; set; }
            public string type { get; set; }
            public List<Attachment> attachments { get; set; }
            public bool can_archive { get; set; }
            public int date { get; set; }
            public int from_id { get; set; }
            public int id { get; set; }
            public bool is_archived { get; set; }
            public bool is_favorite { get; set; }
            public Likes likes { get; set; }
            public string reaction_set_id { get; set; }
            public Reactions reactions { get; set; }
            public int owner_id { get; set; }
            public PostSource post_source { get; set; }
            public string post_type { get; set; }
            public Reposts reposts { get; set; }
            public string text { get; set; }
            public Views views { get; set; }
            public int count { get; set; }
            public string title { get; set; }
            public Asset asset { get; set; }
        }

        public class Likes
        {
            public int can_like { get; set; }
            public int count { get; set; }
            public int user_likes { get; set; }
            public int can_publish { get; set; }
            public bool repost_disabled { get; set; }
        }

        public class Photo
        {
            public int album_id { get; set; }
            public int date { get; set; }
            public int id { get; set; }
            public int owner_id { get; set; }
            public string access_key { get; set; }
            public int post_id { get; set; }
            public List<Size> sizes { get; set; }
            public string text { get; set; }
            public string web_view_token { get; set; }
            public bool has_tags { get; set; }
            public string square_crop { get; set; }
        }

        public class PostSource
        {
            public string platform { get; set; }
            public string type { get; set; }
            public string data { get; set; }
        }

        public class Reactions
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }

        public class ReactionSet
        {
            public string id { get; set; }
            public List<Item> items { get; set; }
        }

        public class Reposts
        {
            public int count { get; set; }
            public int wall_count { get; set; }
            public int mail_count { get; set; }
            public int user_reposted { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
            public List<ReactionSet> reaction_sets { get; set; }
        }

        
        public Response response { get; set; }
        

        public class Size
        {
            public int height { get; set; }
            public string type { get; set; }
            public int width { get; set; }
            public string url { get; set; }
        }

        public class Title
        {
            public Color color { get; set; }
        }

        public class TitleColor
        {
            public string light { get; set; }
            public string dark { get; set; }
        }

        public class Views
        {
            public int count { get; set; }
        }


    }
}
