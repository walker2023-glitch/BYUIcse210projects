
import requests
import json

API_KEY = "af9a52458ca2be17d207a119947e68e0"

lat = 20.8145

long = -111.7833

url = f"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={long}&appid={API_KEY}"

response = requests.get(url)
if response.status_code == 200:
    data = response.json()

    with open("weather_data.json", "w") as f:
        json.dump(data, f)

    print("Data saved to file")
