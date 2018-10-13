# CountDown application

Xamarin.Forms application that gives the user the capability to countdown from any nine lenght number.

## Getting Started

One the user starts the application a default time is setted (10) seconds in order to start the countdown. The user will have three possible options:
-Start
-Pause
-Reset
These options will directly interact with the current countdown.
There is also a configuration button (right on the toolbar) where the user can set a number (integer, max 9 length) in order to change the initial time to countdown.

## Running the tests

There are a few test that are focused on testing the basics of the application (configfuration method and countdown methods).

## Deployment

In order to deploy the solution install the apk attached or generate a new one through this project.
(iOS project ins't attached due that I was unable to test the application for iOS; if it's needed please make me know and I will attached as soon as possible.

## Built With

* [MvvmCross](https://www.mvvmcross.com/) - The MVVM framework used
* [Moq](https://www.nuget.org/packages/moq/) - Mocking framweork fro UTest
* [Xam.Plugin.Settings](https://github.com/jamesmontemagno/SettingsPlugin) - Cross Platfrom Settings (used to save the initial countdown time)


## Authors

* **Lorenzo Navarro** - *Project development* - [Flaurenss](https://github.com/Flaurenss/)


