using ADO.NET_Task6.Commands;
using ADO.NET_Task6.DataAccess.SqlServer;
using ADO.NET_Task6.Domain.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ADO.NET_Task6.Domain.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public RelayCommand PurchaseCommand { get; set; }

        private ObservableCollection<City> cities = new ObservableCollection<City>();

        public ObservableCollection<City> Cities
        {
            get { return cities; }
            set { cities = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Airplane> airplanes = new ObservableCollection<Airplane>();

        public ObservableCollection<Airplane> Airplanes
        {
            get { return airplanes; }
            set { airplanes = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Schedule> schedules = new ObservableCollection<Schedule>();

        public ObservableCollection<Schedule> Schedules
        {
            get { return schedules; }
            set { schedules = value; OnPropertyChanged(); }
        }

        private ObservableCollection<FlightType> flightTypes = new ObservableCollection<FlightType>();

        public ObservableCollection<FlightType> FlightTypes
        {
            get { return flightTypes; }
            set { flightTypes = value; OnPropertyChanged(); }
        }

        private City selectedFromCity;

        public City SelectedCity
        {
            get { return selectedFromCity; }
            set { selectedFromCity = value; OnPropertyChanged(); CityChanged(); }
        }

        private Airplane selectedAirplane;

        public Airplane SelectedAirplane
        {
            get { return selectedAirplane; }
            set { selectedAirplane = value; OnPropertyChanged(); AirplaneChanged(); }
        }

        private Schedule selectedSchedule;

        public Schedule SelectedSchedule
        {
            get { return selectedSchedule; }
            set { selectedSchedule = value; OnPropertyChanged(); }
        }

        private FlightType selectedFlightType;

        public FlightType SelectedFlightType
        {
            get { return selectedFlightType; }
            set { selectedFlightType = value; OnPropertyChanged(); }
        }

        //private Pilot selectedPilot;

        //public Pilot SelectedPilot
        //{
        //    get { return selectedPilot; }
        //    set { selectedPilot = value; OnPropertyChanged(); }
        //}

        private void CityChanged()
        {
            Airplanes = AirplaneService.GetAllAirplanesContaining(SelectedCity);
            Schedules = ScheduleService.GetAllSchedulesContaining(SelectedCity);
        }

        private void AirplaneChanged()
        {
            Schedules = ScheduleService.GetAllSchedulesContaining(SelectedAirplane);
        }  
   
        public string YourName { get; set; }

        private AirplaneRepository AirplaneRepository { get; set; }
        private CityRepository CityRepository { get; set; }
        private FlightTypesRepository FlightTypesRepository { get; set; }
        private PilotRepository PilotRepository { get; set; }
        private ScheduleRepository ScheduleRepository { get; set; }
        private TicketRepository TicketRepository { get; set; }

        private AirplaneService AirplaneService { get; set; }
        private CityService CityService { get; set; }
        private ScheduleService ScheduleService { get; set; }
        private PilotService PilotService { get; set; }

        public MainWindowViewModel()
        {
            AirplaneRepository = new AirplaneRepository();
            CityRepository = new CityRepository();
            FlightTypesRepository = new FlightTypesRepository();
            PilotRepository = new PilotRepository();
            ScheduleRepository = new ScheduleRepository();
            TicketRepository = new TicketRepository();

            AirplaneService = new AirplaneService();
            CityService = new CityService();
            ScheduleService = new ScheduleService();
            PilotService = new PilotService();

            Cities = CityRepository.GetAll();
            Airplanes = AirplaneRepository.GetAll();
            Schedules = ScheduleRepository.GetAll();
            FlightTypes = FlightTypesRepository.GetAll();

            PurchaseCommand = new RelayCommand((p) =>
            {
                if (SelectedCity == null || SelectedAirplane == null || SelectedSchedule == null || SelectedFlightType == null || string.IsNullOrEmpty(YourName))
                {
                    MessageBox.Show("Fill form completely!");
                    return;
                }

                var ticket = new Ticket()
                {
                    AirplaneId = SelectedAirplane.Id,
                    ScheduleId = SelectedSchedule.Id,
                    FlightTypeId = SelectedFlightType.Id,
                    CityId = SelectedCity.Id,
                    Name = YourName
                };
                TicketRepository.AddData(ticket); // error
                MessageBox.Show("Ticket was successfully bought! (Added to tickets)");
            });
        }
    }
}
