using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Domain.Aggregates.PostAggregate
{
    public class PostComment
    {
        private PostComment()
        {
        }

        public Guid Id { get; private set; }
        public Guid PostId { get; private set; }
        public string Text { get; private set; }
        public Guid UserProfileId { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private set; }

        public static PostComment CreatePostComment(Guid postId, string text, Guid userProfileId)
        {
            var comment = new PostComment
            {
                PostId = postId,
                Text = text,
                UserProfileId = userProfileId,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };

            return comment;
        }

        public void UpdateCommentText(string text)
        {
            Text = text;
        }
    }
}
