using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Linq;

namespace PaizaTemplate {

    public class UnitOfWork {

        public void Load(TextReader reader) {
            if (reader == null) throw new ArgumentNullException("reader");
            Contract.EndContractBlock();

            //var h = reader.ReadInt32Enumerable(ReadingDirection.Horizontal, reader.ReadInt32());
            //var v = reader.ReadInt32Enumerable(ReadingDirection.Vertial, reader.ReadInt32());
            //var xy = reader.ReadInt32Enumerable(ReadingDirection.Horizontal, 2).ToArray();
            //var m = reader.ReadInt32Matrix(xy[0], xy[1]);

            throw new NotImplementedException();
        }

        public string Execute() {
            Contract.Ensures(Contract.Result<string>() != null);

            throw new NotImplementedException();
        }
    }

    #region Framework

    public static class Program {

        public static void Main() {
            var uow = new UnitOfWork();
            uow.Load(Console.In);
            var result = uow.Execute();
            Console.WriteLine(result);
        }
    }

    public enum ReadingDirection {
        Horizontal,
        Vertial,
    }

    public static class TextReaderExtensions {

        /// <summary>
        /// reader から Int32 シーケンスを指定方向に向かって読み取ります。
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="direction"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<int> ReadInt32Enumerable(this TextReader reader, ReadingDirection direction, int count) {
            if (reader == null) throw new ArgumentNullException("reader");
            Contract.Ensures(Contract.Result<IEnumerable<int>>() != null);

            switch (direction) {
                case ReadingDirection.Horizontal:
                    var line = reader.ReadLine();
                    if (line == null) throw new InvalidOperationException();
                    return line.SplitBySpace(count).ToInt32Enumerable();

                case ReadingDirection.Vertial:
                    return reader.ReadLines(count).ToInt32Enumerable();

                default:
                    throw new ArgumentOutOfRangeException("direction", direction, null);
            }
        }

        /// <summary>
        /// reader から Int32 の行列を読み取ります。
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="horizontalCount"></param>
        /// <param name="verticalCount"></param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static IEnumerable<IEnumerable<int>> ReadInt32Matrix(this TextReader reader, int horizontalCount, int verticalCount) {
            if (reader == null) throw new ArgumentNullException("reader");
            Contract.Ensures(Contract.Result<IEnumerable<IEnumerable<int>>>() != null);

            return reader.ReadLines(verticalCount).Select(l => l.SplitBySpace(horizontalCount).ToInt32Enumerable());
        }

        /// <summary>
        /// reader から指定された行数分読み取ります。
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<string> ReadLines(this TextReader reader, int count) {
            if (reader == null) throw new ArgumentNullException("reader");
            Contract.Ensures(Contract.Result<IEnumerable<string>>() != null);

            for (int i = 0; i < count; i++) {
                var line = reader.ReadLine();
                if (line == null) throw new InvalidOperationException();
                yield return line;
            }
        }

        /// <summary>
        /// reader から一行読み取り、Int32 に変換します。
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static int ReadInt32(this TextReader reader) {
            if (reader == null) throw new ArgumentNullException("reader");
            Contract.EndContractBlock();

            var line = reader.ReadLine();
            if (line == null) throw new InvalidOperationException();
            return line.ToInt32();
        }
    }

    public static class StringExtensions {

        /// <summary>
        /// 文字列を半角スペースで分割します。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IReadOnlyCollection<string> SplitBySpace(this string value, int count) {
            if (value == null) throw new ArgumentNullException("value");
            Contract.Ensures(Contract.Result<IReadOnlyCollection<string>>() != null);
            Contract.Ensures(Contract.Result<IReadOnlyCollection<string>>().All(s => s != null));
            Contract.Ensures(Contract.Result<IReadOnlyCollection<string>>().Count == Contract.OldValue(count));

            IReadOnlyCollection<string> result = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (result.Count != count) throw new ArgumentOutOfRangeException("value", value, null);
            return result;
        }

        /// <summary>
        /// 文字列を Int32 に変換します。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt32(this string value) {
            if (value == null) throw new ArgumentNullException("value");
            Contract.EndContractBlock();

            return int.Parse(value, CultureInfo.CurrentCulture);
        }
    }

    public static class EnumerableExtensions {

        /// <summary>
        /// 文字列シーケンスを Int32 にシーケンスに変換します。
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<int> ToInt32Enumerable(this IEnumerable<string> source) {
            if (source == null) throw new ArgumentNullException("source");
            Contract.Ensures(Contract.Result<IEnumerable<int>>() != null);

            return source.Select(s => s.ToInt32());
        }
    }

    #endregion Framework
}