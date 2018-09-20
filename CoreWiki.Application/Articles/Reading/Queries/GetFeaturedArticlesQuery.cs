using CoreWiki.Application.Articles.Reading.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWiki.Application.Articles.Reading.Queries
{
	public class GetFeaturedArticlesQuery : IRequest<List<ArticleReadingDto>>
	{
		public int NumOfArticlesToGet { get; }

		public GetFeaturedArticlesQuery(int numOfArticlesToGet)
		{
			NumOfArticlesToGet = numOfArticlesToGet;
		}
	}
}
