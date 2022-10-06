using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextAnalysisApp.Utils
{
    internal class TextParser
    {
        public static List<string> ParseIntoWords(string text)
        {
            // todo: задача #2
            throw new NotImplementedException();
        }

        public static List<string> ParseIntoSentences(string text)
        {
            //text = "Lorem ipsum dolor sit amet. Website: www.test.com. Aut doloremque suscipit aut magni distinctio non perferendis repellat a voluptates provident est repellendus expedita ut natus perspiciatis. Et debitis recusandae eos repellendus quod hic omnis nobis ab accusamus incidunt eum error deserunt sit tenetur! Est provident repellat ut corporis minima qui consequatur dolor in animi cupiditate vel asperiores atque eum alias accusamus non doloremque esse.Aut eligendi similique non alias quaerat sit quaerat quia non esse molestiae et explicabo nostrum aut provident nobis ut voluptatem consequatur? \n Ex consequatur quia est minus repudiandae rem temporibus doloremque. Sit dolor delectus hic laborum autem aut provident neque 33 iusto voluptates aut placeat recusandae.\n Ut numquam eaque ut delectus dolores vel assumenda deserunt ut voluptatem rerum ut deserunt laboriosam et ratione nostrum ut omnis dolor.Eum assumenda illum est blanditiis eius sit dolorem eius et quibusdam officiis At ducimus necessitatibus.";
            List<string> ntext = Regex.Split(text, @"(?<=[\w\s](?:[\.\!\?]+[\x20]*[\x22\xBB]*))(?:\s+(?![\x22\xBB](?!\w)))").ToList();
            return ntext;
        }
        
        public static List<string> ParseIntoPunctuationMarks(string text)
        {
            // todo: задача #4
            throw new NotImplementedException();
        }
    }
}
