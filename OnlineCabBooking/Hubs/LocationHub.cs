
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace OnlineCabBooking.Hubs
{
    public class LocationHub : Hub
    {
        public async Task SendLocation(string rideId, double latitude, double longitude)
        {
            await Clients.Group(rideId).SendAsync("ReceiveLocation", latitude, longitude);
        }

        public async Task JoinRide(string rideId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, rideId);
        }

        public async Task LeaveRide(string rideId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, rideId);
        }
    }
}
