using FakeItEasy;
using FluentAssertions;
using FluentAssertions.Extensions;
using NetworkUtility.DNS;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Test.PingTests
{
    public class NetworkServiceTests
    {

        private readonly NetworkService _pingService;
        private readonly IDNS dNS;

        public NetworkServiceTests() {

            dNS = A.Fake<IDNS>();
           
            _pingService = new NetworkService(dNS);

        
        }


        [Fact]
        public void NetworkService_SendPing_ReturnResult()
        {

            //Arrange

          //  var pingService = new NetworkService();

            A.CallTo(() => dNS.SendDNS()).Returns(true);

            //Act

            string result = _pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success : Ping Sent !");
            result.Should().Contain("Success" , Exactly.Once());


        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(3,3,6)]
        public void NetworkService_SendPing_ReturnTime(int a , int b , int expected)
        {
          //  var pingService = new NetworkService();

            int result = _pingService.PingTime(a,b);

            result.Should().Be(expected);
            result.Should().BeGreaterThan(3);


        }

        [Fact]
        public void NetworkService_GetPingOptions_ReturnResult()
        {

            //Arrange

            //  var pingService = new NetworkService();

            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            //Act

            PingOptions result = _pingService.GetPingOptions();

            //Assert
            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.Ttl.Should().Be(1);


        }

        [Fact]
        public void NetworkService_LastPingDate_ReturnDate()
        {

            var result = _pingService.LastPingDate();

            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));

        }

        [Fact]
        public void NetworkService_MostRecentPing_ReturnRecentPing()
        {

            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            //Act

            var result = _pingService.MostRecentPings();

            //result.Should().BeOfType<IEnumerable<PingOptions>>();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x => x.DontFragment == true);


        }


    }
}
