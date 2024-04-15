# NMBS Tracker
NMBS Tracker is an application designed to notify you when your train is experiencing delays. It automatically refreshes every minute or 5 minutes (configurable) and only triggers an API call when the given time is within a 3-hour range of your scheduled departure.

## API
NMBS Tracker utilizes the API provided by [iRail](https://hello.irail.be/api/1-0/) to fetch information about stations and delays.

## Usage
Upon opening the application, you will encounter a user-friendly interface where you can specify your departure and destination stations. The time you input into the application reflects the scheduled departure time of your train.

The automatic checking starts instantly when you open the application and updates the interval directly when changed. You can save your current input with the save button. These stored settings will be loaded when you reopen the application.

## Contributing
If you'd like to contribute to NMBS Tracker, feel free to fork the repository and submit a pull request. Contributions of all kinds are welcome, including bug fixes, feature enhancements, and documentation improvements. Please note that it may take some time for your pull request to be reviewed.
