using NewsFeed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsFeed.API.SeedData
{
    public static class Seed
    {
        public static List<Channel> Channels
        {
            get
            {
                return new List<Channel> {
                    new Channel() { ChannelId = 1, Name = "UK" },
                    new Channel() { ChannelId = 2, Name = "World" },
                    new Channel() { ChannelId = 3, Name = "Business" },
                    new Channel() { ChannelId = 4, Name = "Tech" }
                };
            }
        }

        public static List<Article> Articles
        {
            get
            {
                return new List<Article> {
                    new Article
                    {
                        ArticleId = 1,
                        ChannelId = 1,
                        Channel = Channels.Single(p => p.Name == "UK"),
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
                        Channel = Channels.Single(p => p.Name == "UK"),
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
                        Channel = Channels.Single(p => p.Name == "UK"),
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
                        Channel = Channels.Single(p => p.Name == "World"),
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
                        Channel = Channels.Single(p => p.Name == "World"),
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
                        Channel = Channels.Single(p => p.Name == "Business"),
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
                        Channel = Channels.Single(p => p.Name == "Tech"),
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
                        Channel = Channels.Single(p => p.Name == "Tech"),
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
                    },
                    new Article
                    {
                        ArticleId = 9,
                        ChannelId = 1,
                        Channel = Channels.Single(p => p.Name == "UK"),
                        Published = new DateTime(2016, 01, 01),
                        Title = "Storm surge flood threat to east coast of England",
                        Leader = "Severe flood warnings are in place along the eastern coast of England, amid fears thousands of homes are at risk from a storm surge.",
                        Body = @"<p>The Environment Agency said the morning tide was not as high as expected but it has issued severe flood warnings - meaning danger to life - for later.</p>" +
                                @"<p>An evacuation was planned for Jaywick, Essex, this morning, while an operation is due in Great Yarmouth, Norfolk.</p>" +
                                @"<p>It comes as the Met Office has warned of high winds, snow and ice on Friday.</p>"

                    },
                    new Article
                    {
                        ArticleId = 10,
                        ChannelId = 2,
                        Channel = Channels.Single(p => p.Name == "World"),
                        Published = new DateTime(2018, 01, 01),
                        Title = "John Kerry finds Vietnam War site where he killed a man",
                        Leader = "The outgoing US Secretary of State John Kerry has visited the place in the Mekong Delta where he was ambushed during the Vietnam war.",
                        Body = @"<p>The former Navy lieutenant met a 70-year-old former member of the Viet Cong, who remembers the 1969 attack.</p>" +
                                @"<p>The pair warmly shook hands.</p>" +
                                @"<p>Mr Kerry, who is in Vietnam as part of his last trip before leaving office, won a medal for bravery for his actions but became an anti - war campaigner after returning home.</p>" +
                                @"<p>Mr Kerry told his former enemy, Vo Ban Tam, he was glad they were both alive.</p>" +
                                @"<p>Mr Tam, now a shrimp farmer, said he knew a man whom Mr Kerry shot and killed and remembered the plan of attack when they first spotted the US patrol boat.</p>"
                    },
                    new Article
                    {
                        ArticleId = 11,
                        ChannelId = 2,
                        Channel = Channels.Single(p => p.Name == "World"),
                        Published = new DateTime(2018, 01, 01),
                        Title = "Israel-Palestinian conflict: France holds world summit",
                        Leader = "A major international conference to try to kick-start peace talks between Israel and the Palestinians is being held in the French capital, Paris.",
                        Body = @"<p>Delegates from 70 nations are expected to reaffirm support for a two-state solution to the decades - old conflict.</p>" +
                                @"<p>Palestinians have welcomed the meeting but Israel - which is not attending - says the conference is loaded against it.</p>" +
                                @"<p>The last round of direct peace talks collapsed amid acrimony in April 2014.</p>" +
                                @"<p>Israel and the Palestinians have been invited to hear the conclusions of the meeting, but not to participate in the summit itself.</p>"
                    },
                    new Article
                    {
                        ArticleId = 12,
                        ChannelId = 2,
                        Channel = Channels.Single(p => p.Name == "World"),
                        Published = new DateTime(2018, 01, 01),
                        Title = "Brazil prisoners beheaded in riot at Natal prison",
                        Leader = "At least 10 prisoners have been killed in fighting between rival gangs at the largest prison in the north-eastern Brazilian city of Natal, police say.",
                        Body = @"<p>It took 14 hours for police to regain control of Alcacuz jail.</p>" +
                                @"<p>""The operation is still ongoing but the situation is now calm"", a spokesperson told BBC Brasil.</p>" +
                                @"<p>This is the third major riot in Brazil this year.Nearly 100 inmates died in riots earlier this month in prisons in the states of Amazonas and Roraima.</p>" +
                                @"<p>The violence inside Alcacuz jail, in Rio Grande Do Norte state, began on Saturday afternoon, when members of one of the powerful criminal organisations present in most Brazilian jails attacked rivals in a separate wing.</p>" + 
                                @"<p>""We could see the heads ripped off"" three of the dead prisoners, said Zemilton Silva, coordinator of the prison system.</p>" +
                                @"<p>Security forces managed to enter the outer area of the prison but decided to wait for daylight hours before going in on Sunday morning.</p>"
                    },
                    new Article
                    {
                        ArticleId = 13,
                        ChannelId = 4,
                        Channel = Channels.Single(p => p.Name == "Tech"),
                        Published = new DateTime(2018, 01, 01),
                        Title = "Faraday Future's cash flow woe",
                        Leader = "Faraday Future, the company hoping to beat Tesla in the electric car game, had to halt building its factory in order to afford its glitzy CES press event, the firm told the BBC.",
                        Body = @"<p>The company broke ground on its enormous plant in the Nevada desert in April last year - but work halted in October amid reports the company was in dire financial straits.</p>" +
                                @"<p>Speaking on the record for the first time about the firm’s money woes, Faraday Future’s senior vice president of research and design, Nick Sampson, acknowledged the company was facing ""challenges"".</p>" +
                                @"<p>""Clearly something like [CES] requires funding and some resources,"" Mr Sampson told me.</p>" +
                                @"<p>""We are resource-limited at times. [It's] just a matter of keeping the cash flow balance between the different projects we’re trying to do.""</p>" +
                                @"<p>No date has been set for work on the site to recommence.</p>"
                    },
                    new Article
                    {
                        ArticleId = 14,
                        ChannelId = 4,
                        Channel = Channels.Single(p => p.Name == "Tech"),
                        Published = new DateTime(2018, 01, 01),
                        Title = "Moderate screen use 'boosts teen wellbeing'",
                        Leader = "A study of screen time and mental wellbeing among teenagers has suggested moderate use of devices may be beneficial in a connected world.",
                        Body = @"<p>The researchers collected self-reported data from 120,000 English 15-year-olds about their digital device habits.</p>" +
                                @"<p>They found a ""Goldilocks effect"" where a few hours of device-use seemed to boost mental wellbeing.</p>" +
                                @"<p>One developmental psychologist welcomed the paper but said there was still room for more study.</p>" +
                                @"<p>""Moderate engagement in digital activities is not harmful,"" notes the paper, published today in the journal Psychological Science.</p>" +
                                @"<p>In addition, the first hour or two of screen time was actually associated with an increase in mental wellbeing for those using computers, smartphones, video games and watching TV or films.</p>" 
                    },
                    new Article
                    {
                        ArticleId = 15,
                        ChannelId = 4,
                        Channel = Channels.Single(p => p.Name == "Tech"),
                        Published = new DateTime(2018, 01, 01),
                        Title = "Bug 'exposes' WhatsApp message secrets",
                        Leader = "Some messages sent through WhatsApp can be intercepted and read thanks to a bug in the app, suggests research.",
                        Body = @"<p>The bug arises because of the way WhatsApp encrypts the messages sent via its service.</p>" +
                                @"<p>Security expert Thomas Boelter found that eavesdropping was possible when circumstances called for encryption keys to be reissued.</p>" +
                                @"<p>Mr Boelter told WhatsApp owner Facebook about the issue in April 2016 but it said it was not working on a fix.</p>" +
                                @"<p>The response he received said that what he had discovered was expected behaviour.</p>"
                    }
                };
            }
        }
    }
}