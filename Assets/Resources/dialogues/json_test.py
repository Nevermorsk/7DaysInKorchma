import json
with open('dialogue_day1.json', encoding="UTF-8") as file:
    s = json.load(file)
    print(s[0]["text"])