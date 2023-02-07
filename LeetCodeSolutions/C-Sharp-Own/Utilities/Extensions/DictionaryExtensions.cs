using System;
using System.Collections.Generic;

namespace Utilities.Extensions
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// 将指定的键值对列表添加到字典中
        /// </summary>
        /// <param name="dic">字典</param>
        /// <param name="enumerable">键值对列表</param>
        /// <typeparam name="TKey">键类型</typeparam>
        /// <typeparam name="TValue">值类型</typeparam>
        /// <exception cref="ArgumentException">
        /// 字典<paramref name="dic"/>中已存在集合<paramref name="enumerable"/>中的键
        /// </exception>
        public static void AddMany<TKey, TValue>(this Dictionary<TKey, TValue> dic, IEnumerable<(TKey, TValue)> enumerable) where TKey : notnull
        {
            foreach (var (key, value) in enumerable)
            {
                dic.Add(key, value);
            }
        }
    }
}
