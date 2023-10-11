// See https://aka.ms/new-console-template for more information

using P5_2Harvest;

var plant = new Plant();
var grain = new Grain();
var wheat = new Wheat();

plant.CanGrow();
grain.CanGrow();
grain.CanBeHarvested();
wheat.CanGrow();
wheat.CanBeHarvested();
wheat.CanBeProcessedToBread();