using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Domain.Aggregates.PostAggregate
{
    public class PostInteraction
    {
        private PostInteraction()
        {
        }

        public Guid Id { get; private set; }
        public Guid PostId { get; private set; }
        public EInteraction InteractionType { get; private set; }

        public static PostInteraction CreatePostInteraction(Guid postId, EInteraction interactionType)
        {
            var postInteraction = new PostInteraction
            {
                PostId = postId,
                InteractionType = interactionType
            };

            return postInteraction;
        }

    }
}
