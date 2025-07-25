// Code generated by Fern. DO NOT EDIT.

package service

import (
	context "context"
	fmt "fmt"
	fern "github.com/examples/fern"
	core "github.com/examples/fern/core"
	file "github.com/examples/fern/file"
	internal "github.com/examples/fern/internal"
	option "github.com/examples/fern/option"
	http "net/http"
)

type Client struct {
	baseURL string
	caller  *internal.Caller
	header  http.Header

	WithRawResponse *RawClient
}

func NewClient(opts ...option.RequestOption) *Client {
	options := core.NewRequestOptions(opts...)
	return &Client{
		baseURL: options.BaseURL,
		caller: internal.NewCaller(
			&internal.CallerParams{
				Client:      options.HTTPClient,
				MaxAttempts: options.MaxAttempts,
			},
		),
		header:          options.ToHeader(),
		WithRawResponse: NewRawClient(options),
	}
}

// This endpoint returns a file by its name.
func (c *Client) GetFile(
	ctx context.Context,
	// This is a filename
	filename string,
	request *file.GetFileRequest,
	opts ...option.RequestOption,
) (*fern.File, error) {
	options := core.NewRequestOptions(opts...)
	baseURL := internal.ResolveBaseURL(
		options.BaseURL,
		c.baseURL,
		"",
	)
	endpointURL := internal.EncodeURL(
		baseURL+"/file/%v",
		filename,
	)
	headers := internal.MergeHeaders(
		c.header.Clone(),
		options.ToHeader(),
	)
	headers.Add("X-File-API-Version", fmt.Sprintf("%v", request.XFileApiVersion))
	errorCodes := internal.ErrorCodes{
		404: func(apiError *core.APIError) error {
			return &fern.NotFoundError{
				APIError: apiError,
			}
		},
	}

	var response *fern.File
	if _, err := c.caller.Call(
		ctx,
		&internal.CallParams{
			URL:             endpointURL,
			Method:          http.MethodGet,
			Headers:         headers,
			MaxAttempts:     options.MaxAttempts,
			BodyProperties:  options.BodyProperties,
			QueryParameters: options.QueryParameters,
			Client:          options.HTTPClient,
			Response:        &response,
			ErrorDecoder:    internal.NewErrorDecoder(errorCodes),
		},
	); err != nil {
		return nil, err
	}
	return response, nil
}
