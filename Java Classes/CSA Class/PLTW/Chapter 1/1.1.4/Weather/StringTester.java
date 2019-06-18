public class StringTester
{
    static String weatherCondition = "scattered thunderstorms";
    static String firstFive = weatherCondition.substring(0,5);
    public static void main(String Args[]){
        //number 7
        System.out.println(firstFive);
        System.out.println(WeatherConditionals.getWeatherAdvice(32, "heavy snow, windy"));
        System.out.println(WeatherConditionals.getWeatherAdvice(55, "sunny"));
        System.out.println(WeatherConditionals.getWeatherAdvice(-21, "cold"));
        System.out.println(WeatherConditionals.getWeatherAdvice(100, "heavy snow"));
        System.out.println(WeatherConditionals.getWeatherAdvice(25, "Windy with clouds"));
    }
}
