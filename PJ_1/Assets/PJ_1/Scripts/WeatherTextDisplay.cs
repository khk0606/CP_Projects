using UnityEngine;
using TMPro;  // TextMeshPro 사용을 위해 필요

public class WeatherTextDisplay : MonoBehaviour
{
    [Header("UI text")]
    public TextMeshProUGUI temperatureText;  // TextMeshPro 텍스트 컴포넌트

    [Header("Weather Data")]
    public float currentTemperature = 25.0f;  // 현재 온도
    public string locationName = "Seoul";       // 지역 이름

    // WeatherTextDisplay 클래스 안에 추가 (Update 함수 아래에)

    void Start()
    {
        // 게임 시작시 한번 실행
        Debug.Log("날씨 텍스트 시스템 시작!");

        // 텍스트가 연결되었는지 확인
        if (temperatureText == null)
        {
            Debug.LogError("TextMeshPro 컴포넌트가 연결되지 않았습니다!");
        }
        else
        {
            Debug.Log("텍스트 컴포넌트 연결 완료!");
        }
    }

    void Update()
    {
        //UpdateWeatherDisplay();  // 날씨 화면 업데이트만
        if (temperatureText != null)
        {
            //텍스트 내용 업데이트
            temperatureText.text = locationName + " Current temp: " + currentTemperature.ToString("F1") + "C";
        }
    }

    public void ChangeToSpring()
    {
        // 봄 설정값들
        currentTemperature = 15.0f;      // 봄 온도: 15도
        locationName = "Spring Seoul";       // 봄 테마 지역명

        // 디버그 메시지로 함수 실행 확인
        Debug.Log("Change to Spring! Temp: " + currentTemperature + "C");
    }
    public void ChangeToSummer()
    {
        // 봄 설정값들
        currentTemperature = 30.0f;      // 봄 온도: 15도
        locationName = "Summer Seoul";       // 봄 테마 지역명

        // 디버그 메시지로 함수 실행 확인
        Debug.Log("Change to Summer! Temp: " + currentTemperature + "C");
    }
    public void ChangeToAutumn()
    {
        // 봄 설정값들
        currentTemperature = 25.0f;      // 봄 온도: 15도
        locationName = "Autumn Seoul";       // 봄 테마 지역명

        // 디버그 메시지로 함수 실행 확인
        Debug.Log("Change to Autumn! Temp: " + currentTemperature + "C");
    }
    public void ChangeToWinter()
    {
        // 봄 설정값들
        currentTemperature = 1.0f;      // 봄 온도: 15도
        locationName = "Winter Seoul";       // 봄 테마 지역명

        // 디버그 메시지로 함수 실행 확인
        Debug.Log("Change to winter! Temp: " + currentTemperature + "C");
    }

}