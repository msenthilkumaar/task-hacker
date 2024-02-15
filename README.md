## Developer Coding Task

Follow these steps to run the application:

1. Download the code from this repository.
2. Open the solution file using the latest version of Visual Studio. (I used Visual Studio 2022).
3. Run the application with the `hacker_news_bamboo_card` profile.
4. It will open the browser with Swagger UI.
5. Expand `BestStories` and navigate to the `GetBestStories` endpoint.
6. Click on "Try It Out" and enter the number of stories (`numberOfStoriesToLoad`).
7. Click "Execute".

Note: Currently, I have used the Flurl library to load data. I have implemented async functions throughout the project, and I am not using any caching mechanism.