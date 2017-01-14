namespace NewsFeed.API.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Models;
    using System.Linq;
    using Domain.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsFeed.API.Models.NewsFeedAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NewsFeed.API.Models.NewsFeedAPIContext context)
        {
            context.Channels.AddOrUpdate(SeedData.Seed.Channels.ToArray());

            /*context.Channels.AddOrUpdate(
                new Channel() { ChannelId = 1, Name = "UK" },
                new Channel() { ChannelId = 2, Name = "World" },
                new Channel() { ChannelId = 3, Name = "Business" },
                new Channel() { ChannelId = 4, Name = "Tech" }
                );*/

            context.Articles.AddOrUpdate(SeedData.Seed.Articles.ToArray());

            /*context.Articles.AddOrUpdate(
                new Article
                {
                    ArticleId = 1,
                    ChannelId = 1,
                    Published = new DateTime(2015, 01, 01),
                    Title = "Flights cancelled ahead of snowy conditions",
                    Leader = "Flights have been cancelled amid warnings of blizzard conditions set to sweep across the UK on Thursday.",
                    Body = @"<p>London's Heathrow Airport said airlines had pre-emptively cancelled 80 out of 1,350 flights, with disruption expected from 15:00 GMT. Four flights at Gatwick Airport have also been cancelled.</p>" +
                            @"<p>Heathrow Airport said without the cancellations it could not reschedule any flights delayed by the weather.</p>" +
                            @"<p>The Met Office has issued yellow warnings for snow for much of the UK.</p>" +
                            @"<p>The ""be aware"" warnings are in place for many areas of the country until Saturday.</p>" +
                            @"<p>At Heathrow Airport, 6 % of the usual daily flights are cancelled.</p>"
                },
                new Article
                {
                    ArticleId = 2,
                    ChannelId = 1,
                    Published = new DateTime(2015, 01, 01),
                    Title = "Llandudno Ysgol Maelgwn teacher 'taped boy to chair'",
                    Leader = "A teacher from Conwy county taped an eight-year-old boy to a chair by his bare ankles for fidgeting, a disciplinary panel has been told.",
                    Body = @"<p>Matthew Brown, 38, later told the head teacher of Ysgol Maelgwn, Llandudno Junction, he did it as a joke but realised he had acted foolishly.</p>" +
                            @"<p>He was accused of unacceptable professional conduct at an Education Workforce Council hearing in Ewloe.</p>" +
                            @"<p>Mr Brown did not appear at the hearing but denies acting unprofessionally.</p>" +
                            @"<p> Gisella Williams, head teacher at the time, said Mr Brown was a well-liked supply teacher at the primary school for a number of years, teaching a class of seven and eight-year-olds.</p>" +
                            @"<p>Miss Williams said the father of ""Pupil A"" had visited her at the school in July 2015.</p>" +
                            @"<p>""The father said Pupil A was extremely reluctant to attend school that day,"" she said.</p>" +
                            @"<p>The pupil, wearing shorts, had been upset by what happened.</p>" +
                            @"<h2>'Unprofessional'</h2></p>" +
                            @"<p>Miss Williams said she was shocked and Mr Brown appeared very remorseful when she confronted him.</p>" +
                            @"<p>""I felt Matthew Brown's conduct was unprofessional and foolish. I don't think he was setting a good example for the children,"" she said.</p>" +
                            @"<p>""I don't think Mr Brown thought about his actions or thought about the consequences for his career.""</p>" +
                            @"<p>She added she had not had any previous concerns about his work.</p>" +
                            @"<p>Mr Brown was also accused of Sellotaping Pupil A's hands to a desk and taping the hand of a girl - ""Pupil B"" - to a ball.</p>" +
                            @"<p>Committee chairman Steve Powell said he appeared to suggest the ball incident was an accident.</p>" +
                            @"<p>Presenting officer Carys Williams said Mr Brown had de - registered as a teacher.He had been covering for a teacher on maternity leave at the time.</p>" +
                            @"<p>The hearing continues.</p>" 
                },
                new Article
                {
                    ArticleId = 3,
                    ChannelId = 1,
                    Published = new DateTime(2015, 01, 01),
                    Title = "Beatles poster artist Tony Booth dies aged 83",
                    Leader = "The artist who created posters for The Beatles in Liverpool in the early 1960s has died aged 83.",
                    Body = @"<p>Tony Booth, from Moreton, Wirral, made the iconic signs for the Fab Four and other Merseybeat bands in the 1960s.</p>" +
                            @"<p>He died on Wednesday at Wirral's Arrowe Park Hospital after a battle with cancer, his son Lee Booth said.</p>" +
                            @"<p> In recent years, Mr Booth made replicas of the posters for fans and had written a book about them which his son hopes will be ""part of his legacy"".</p>" +
                            @"<p>Mr Booth was hired by Beatles manager Brian Epstein and started off making ""a few posters and show cards for his shops"" before moving on to hand - painted concert posters.</p>" +
                            @"<p>In the days before the internet, the posters were the main way of telling fans of upcoming gigs. Though few of the originals survived, one from 1962 advertising a night with Little Richard and The Beatles in The Tower Ballroom in New Brighton was uncovered during the refurbishment of Bidston train station in 2013.</p>" +
                            @"<p> It is now displayed in the Merseybeat room of The Beatles Story museum in Liverpool's Albert Dock.</p>" +
                            @"<p>In August last year, Mr Booth staged his first exhibition at View Two Gallery on Mathew Street after reproducing 40 of his favourite posters with the same materials he used more than 50 years ago.</p>" +
                            @"<p>One of Mr Booth's last projects was to produce posters for The Cavern club's 60th anniversary celebrations this weekend, which his son said was fitting as ""one of the earliest posters"" had been for its opening.</p>" +
                            @"<p>""He started his career with The Cavern club and finished his career with The Cavern club"", he said.</p>" +
                            @"<p>""I've had posters around me all my life, they''re part of Liverpool''s history"".</p>"
                },
                new Article
                {
                    ArticleId = 4,
                    ChannelId = 2,
                    Published = new DateTime(2015, 01, 01),
                    Title = "US tanks and troops in Poland a threat, Russia says",
                    Leader = "Russia says it views the arrival of more than 3,000 US soldiers in Poland as a threat to its own security.",
                    Body = @"<p>The troops are part of President Barack Obama's response to reassure Nato allies concerned about a more aggressive Russia.</p>" +
                            @"<p>It is the largest US military reinforcement of Europe in decades.</p>" +
                            @"<p>President Vladimir Putin's spokesman Dmitry Peskov told the BBC that the move ""threatens our interests and our security"".</p>" +
                            @"<p>""It's a third country that is building up its military presence on our borders in Europe,"" he said. ""It isn't even a European country.""</p>" +
                            @"<p>Russian Deputy Foreign Minister Alexei Mechkov called the deployment a ""factor destabilising European security"".</p>" +
                            @"<p>Poland's Undersecretary of State for Defence Tomasz Szatkowski said the deployment was necessary because of Russia's ""large exercises"" next to its border and its ""aggressive actions in our vicinity - I mean Ukraine and the illegal annexation of Crimea"".</p>"
                },
                new Article
                {
                    ArticleId = 5,
                    ChannelId = 2,
                    Published = new DateTime(2015, 01, 01),
                    Title = "Tigerair trouble strands hundreds of tourists in Bali",
                    Leader = "Hundreds of passengers have been stranded in Bali after Indonesia said Tigerair did not have permission to operate some flights to Australia.",
                    Body = @"<p>Flights between Bali and Australia will not run until at least Friday following the ""new requirements"", Tigerair said.</p>" +
                            @"<p>Indonesia disputed Tigerair's claim the rules were new, saying the airline only had permission for charter flights.</p>" +
                            @"<p>More than one million Australians visit Indonesia each year, with most heading to Bali, a popular holiday island.</p> " +
                            @"<p>About 700 passengers were affected by the cancellations on Wednesday, while a similar number will be grounded on Thursday, the airline said.</p> " +
                            @"<p>""We are working constructively with the Indonesian government to commence flying to Bali again as soon as possible and to work through the new requirements they have given us this week,"" Tigerair Australia chief Rob Sharp said in a statement to the BBC.</p>"
                },
                new Article
                {
                    ArticleId = 6,
                    ChannelId = 3,
                    Published = new DateTime(2016, 01, 01),
                    Title = "Lloyds online banking problems enter second day",
                    Leader = "Customers of Lloyds Banking Group have expressed frustration at a second day of problems with online and app banking.",
                    Body = @"<p>The group. which includes Lloyds Bank, the Halifax and Bank of Scotland, said it had suffered problems across all its brands on Wednesday.</p>" +
                            @"<p>At one point the bank assured customers that the glitch had been resolved.</p>" + 
                            @"<p>However, customers are reporting that they are unable to access online and app banking on Thursday morning.</p>"
                },
                new Article
                {
                    ArticleId = 7,
                    ChannelId = 4,
                    Published = new DateTime(2016, 01, 01),
                    Title = "MEPs vote on robots' legal status - and if a kill switch is required",
                    Leader = "MEPs have called for the adoption of comprehensive rules for how humans will interact with artificial intelligence and robots.",
                    Body = @"<p>The report makes it clear that it believes the world is on the cusp of a ""new industrial"" robot revolution.</p>" +
                            @"<p>It looks at whether to give robots legal status as ""electronic persons"".</p>" +
                            @"<p>Designers should make sure any robots have a kill switch, which would allow functions to be shut down if necessary, the report recommends.</p>" +
                            @"<p>Meanwhile users should be able to use robots ""without risk or fear of physical or psychological harm"", it states.</p>" +
                            @"<p>Lorna Brazell, a partner at law firm Osborne Clarke, was surprised by how far-reaching the rules were.</p>" +
                            @"<p> But questioned the need to give future robots legal status.</p>" +
                            @"<p>""Blue whales and gorillas don't have personhood but I would suggest that they have as many aspects of humanity as robots, so I don't see why we should jump into giving robots this status."" </p>" 
                },
                new Article
                {
                    ArticleId = 8,
                    ChannelId = 4,
                    Published = new DateTime(2017, 01, 01),
                    Title = "HTC phones tell users to wrap up warm",
                    Leader = "HTC's latest smartphones use software that studies its owners' behaviour and plans, and then makes recommendations based of what it has gleaned.",
                    Body = @"<p>The feature - called the Sense Companion - can be used to maximise battery life and suggest what to wear.</p>" +
                            @"<p> The larger of the two devices - the U Ultra - is also marked out by the fact it has two separate displays.</p>" +
                            @"<p>The ""mid range"" devices are the latest to have been unveiled this year.</p>" +
                            @"<p>Samsung, Nokia, LG, Asus and Huawei are among those to have had rival launches over the past fortnight.</p>" +
                            @"<p>HTC, however, is under particular pressure for the new U Play and U Ultra to be hits.</p>" +
                            @"<p>The firm has posted a financial loss in each of its last six quarterly earnings reports, and announced its lowest year's revenue in more than a decade for 2016.</p>" +
                            @"<p>It has yet to announce how much the new devices will cost.</p>"
                }
                );*/
        }
    }
}
