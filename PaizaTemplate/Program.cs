using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Linq;

namespace PaizaTemplate {

    public class UnitOfWork : UowBase {

        public static UnitOfWork Load(TextReader reader) {
            //var h = reader.ReadInt32Enumerable(ReadingDirection.Horizontal, reader.ReadInt32());
            //var v = reader.ReadInt32Enumerable(ReadingDirection.Vertial, reader.ReadInt32());
            //var xy = reader.ReadInt32Enumerable(ReadingDirection.Horizontal, 2).ToArray();
            //var m = reader.ReadInt32Matrix(xy[0], xy[1]);

            throw new NotImplementedException();
        }

        public override string Execute() {
            throw new NotImplementedException();
        }
    }

    #region Framework

    public static class Program {

        public static void Main() {
            var uow = UnitOfWork.Load(Console.In);
            var result = uow.Execute();
            Console.WriteLine(result);
        }
    }

    public abstract class UowBase {

        public abstract string Execute();
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
            if (reader == null) throw new ArgumentNullException(nameof(reader));
            Contract.Ensures(Contract.Result<IEnumerable<int>>() != null);
            Contract.Ensures(Contract.Result<IEnumerable<int>>().Count() == Contract.OldValue(count));

            IEnumerable<int> result;
            switch (direction) {
                case ReadingDirection.Horizontal:
                    var line = reader.ReadLine();
                    if (line == null) throw new InvalidOperationException();
                    result = line.SplitBySpace(count).ToInt32Enumerable();
                    break;

                case ReadingDirection.Vertial:
                    result = reader.ReadLines(count).ToInt32Enumerable();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }

            Contract.Assume(result.Count() == count);
            return result;
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
            if (reader == null) throw new ArgumentNullException(nameof(reader));
            Contract.Ensures(Contract.Result<IEnumerable<IEnumerable<int>>>() != null);
            Contract.Ensures(Contract.Result<IEnumerable<IEnumerable<int>>>().All(s => s != null));

            var result = reader.ReadLines(verticalCount).Select(l => l.SplitBySpace(horizontalCount).ToInt32Enumerable());
            Contract.Assume(result.All(s => s != null));
            return result;
        }

        /// <summary>
        /// reader から指定された行数分読み取ります。
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<string> ReadLines(this TextReader reader, int count) {
            if (reader == null) throw new ArgumentNullException(nameof(reader));
            Contract.Ensures(Contract.Result<IEnumerable<string>>() != null);
            Contract.Ensures(Contract.Result<IEnumerable<string>>().All(s => s != null));
            Contract.Ensures(Contract.Result<IEnumerable<string>>().Count() == Contract.OldValue(count));

            var result = _ReadLines(reader, count);
            Contract.Assume(result.All(s => s != null));
            Contract.Assume(result.Count() == count);
            return result;
        }

        private static IEnumerable<string> _ReadLines(this TextReader reader, int count) {
            Contract.Requires(reader != null);
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
            if (reader == null) throw new ArgumentNullException(nameof(reader));
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
            if (value == null) throw new ArgumentNullException(nameof(value));
            Contract.Ensures(Contract.Result<IReadOnlyCollection<string>>() != null);
            Contract.Ensures(Contract.Result<IReadOnlyCollection<string>>().All(s => s != null));
            Contract.Ensures(Contract.Result<IReadOnlyCollection<string>>().Count == Contract.OldValue(count));

            IReadOnlyCollection<string> result = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (result.Count != count) throw new ArgumentOutOfRangeException(nameof(value), value, null);
            return result;
        }

        /// <summary>
        /// 文字列を Int32 に変換します。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt32(this string value) {
            if (value == null) throw new ArgumentNullException(nameof(value));
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
            if (source == null) throw new ArgumentNullException(nameof(source));
            Contract.Requires(source.All(s => s != null));
            Contract.Ensures(Contract.Result<IEnumerable<int>>() != null);
            Contract.Ensures(Contract.Result<IEnumerable<int>>().Count() == Contract.OldValue(source).Count());

            var result = source.Select(s => s.ToInt32());
            Contract.Assume(result.Count() == source.Count());
            return result;
        }
    }

    #endregion Framework
}