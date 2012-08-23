using System.Collections.Generic;
using System.Data.Entity;
using DreamCarsMVC4.Models;
using DreamCarsMVC4.Models.Enumerations;

namespace DreamCarsMVC4.Data.Context {

    public class DataContextInitializer : DropCreateDatabaseIfModelChanges<DataContext> {

        private Manufacturer _astonMartin;
        private Model _astonMartinDB9;
        private Engine _astonMartinV12;
        private Model _astonMartinV12Vantage;
        private Manufacturer _ferrari;
        private Model _ferrari458Italia;
        private Model _ferrariScaglietti;
        private Engine _ferrariV12;
        private Engine _ferrariV8;
        private Manufacturer _lamborghini;
        private Model _lamborghiniAventador;
        private Model _lamborghiniGallardo;
        private Engine _lamborghiniV10;
        private Engine _lamborghiniV12;
        private Manufacturer _porsche;
        private Model _porsche911GT2R2;
        private Engine _porscheStraight6;

        protected override void Seed(DataContext context) {
            SeedManufacturer(context);
            SeedEngine(context);
            SeedModel(context);
            base.Seed(context);
        }

        private void SeedManufacturer(DataContext context) {
            _ferrari = new Manufacturer {Name = "Ferrari", Country = "Italy", Image = "ferrari.jpg"};
            _lamborghini = new Manufacturer { Name = "Lamborghini", Country = "Italy", Image = "lamborghini.png" };
            _astonMartin = new Manufacturer { Name = "Aston Martin", Country = "United Kingdom", Image = "astonmartin.png" };
            _porsche = new Manufacturer { Name = "Porsche", Country = "Germany", Image = "porsche.png" };
            new List<Manufacturer> {_ferrari, _lamborghini, _astonMartin, _porsche}.ForEach(x => context.Manufacturers.Add(x));
        }

        private void SeedEngine(DataContext context) {
            _astonMartinV12 = new Engine {Name = "6.0L V12", BreakHorsepower = 510, NumberOfCylinders = 12, Liters = 6.0m};
            _ferrariV8 = new Engine {Name = "5.4L V8", BreakHorsepower = 570, NumberOfCylinders = 8, Liters = 5.4m};
            _ferrariV12 = new Engine {Name = "5.7L V12", BreakHorsepower = 532, NumberOfCylinders = 12, Liters = 5.7m};
            _lamborghiniV10 = new Engine {Name = "5.2L V10", BreakHorsepower = 562, NumberOfCylinders = 10, Liters = 5.2m};
            _lamborghiniV12 = new Engine {Name = "6.5L V12", BreakHorsepower = 700, NumberOfCylinders = 12, Liters = 6.5m};
            _lamborghiniV12 = new Engine {Name = "6.5L V12", BreakHorsepower = 700, NumberOfCylinders = 12, Liters = 6.5m};
            _porscheStraight6 = new Engine {Name = "3.6L Straight 6", BreakHorsepower = 620, NumberOfCylinders = 6, Liters = 3.6m};
            new List<Engine> {_astonMartinV12, _ferrariV8, _ferrariV12, _lamborghiniV10, _lamborghiniV12, _porscheStraight6}.ForEach(x => context.Engines.Add(x));
        }

        private void SeedModel(DataContext context) {
            _ferrari458Italia = new Model {Name = "458 Italia", BasePrice = 220000, Year = 2012, Manufacturer = _ferrari, AvailableEngines = new List<Engine> {_ferrariV8, _ferrariV12}, EngineLocation = EngineLocationType.Mid, Image = "458Italia.jpg"};
            _ferrariScaglietti = new Model { Name = "Scaglietti", BasePrice = 313000, Year = 2012, Manufacturer = _ferrari, AvailableEngines = new List<Engine> { _ferrariV12 }, EngineLocation = EngineLocationType.Front, Image = "scaglietti.jpg" };
            _lamborghiniGallardo = new Model {Name = "Gallardo LP 570-4 Superleggera", BasePrice = 237600, Year = 2012, Manufacturer = _lamborghini, AvailableEngines = new List<Engine> {_lamborghiniV10}, EngineLocation = EngineLocationType.Mid, Image = "superleggra.jpg"};
            _lamborghiniAventador = new Model { Name = "Aventador LP 700-4", BasePrice = 387000, Year = 2012, Manufacturer = _lamborghini, AvailableEngines = new List<Engine> { _lamborghiniV12 }, EngineLocation = EngineLocationType.Mid, Image = "aventador.jpg" };
            _astonMartinDB9 = new Model { Name = "DB9", BasePrice = 185000, Year = 2012, Manufacturer = _astonMartin, AvailableEngines = new List<Engine> { _astonMartinV12 }, EngineLocation = EngineLocationType.Front, Image = "db9.jpg" };
            _astonMartinV12Vantage = new Model { Name = "V12 Vantage", BasePrice = 180000, Year = 2012, Manufacturer = _astonMartin, AvailableEngines = new List<Engine> { _astonMartinV12 }, EngineLocation = EngineLocationType.Front, Image = "V12Vantage.jpg" };
            _porsche911GT2R2 = new Model { Name = "911 GT2 R2", BasePrice = 245000, Year = 2012, Manufacturer = _porsche, AvailableEngines = new List<Engine> { _porscheStraight6 }, EngineLocation = EngineLocationType.Rear, Image = "911GT2.jpg" };
            new List<Model> {_ferrari458Italia, _ferrariScaglietti, _lamborghiniAventador, _lamborghiniGallardo, _astonMartinDB9, _astonMartinV12Vantage, _porsche911GT2R2}.ForEach(x => context.Models.Add(x));
        }
    }
}