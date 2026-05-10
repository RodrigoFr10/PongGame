using UnityEngine;

public static class JsonHelper //Unity não consegue entender jason diretamente. Esse script auxilia nisso
{
    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] array;
    }

    public static T[] FromJson<T>(string json)
    {
        string newJson = "{ \"array\": " + json + "}";

        Wrapper<T> wrapper =
            JsonUtility.FromJson<Wrapper<T>>(newJson);

        return wrapper.array;
    }
}